using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmProductPriceDetail : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        ProductPrice m_Price;
        List<Product> m_lstPrice;
        public frmProductPriceDetail()
        {
            InitializeComponent();
            m_Price = null;
            m_lstPrice = null;
        }
        public frmProductPriceDetail(ProductPrice productPrice)
        {
            InitializeComponent();
            m_Price = productPrice;
        }
        private void loadProdCode()
        {
            m_lstPrice = new List<Product>();
            m_lstPrice = db.Query<Product>("Select Id, Name,Code from Product").ToList();
            if (m_lstPrice == null) m_lstPrice = new List<Product>();
            if(m_lstPrice!=null)
            {
                cbbProdCode.DataSource = m_lstPrice;
                cbbProdCode.DisplayMember = "Code";
                cbbProdCode.ValueMember = "Id";
            }   
        }
        private void frmProductPriceDetail_Load(object sender, EventArgs e)
        {
            if(m_Price!=null)
            {
                loadProdCode();
                Edit();
            }
            else
            if(m_Price==null)
            {
                loadProdCode();
            }
        }
        private void Edit()
        {
            txtName.Text = m_Price.PriceName;
            txtPrice.Text = m_Price.Price.ToString();
            txtNote.Text = m_Price.Note;
            dtpActiveDate.Value = m_Price.ActiveDate.Value;
            cbActive.Checked = m_Price.Active==null?false:m_Price.Active.Value;
            cbbProdCode.SelectedValue = m_Price.Product.ProductId;
            txtProductName.Text = m_Price.Product.ProductName;
            txtCreateBy.Text = m_Price.User.UserName;
            txtCreateDate.Text = m_Price.CreateDate.ToString();
            cbbProdCode.Enabled = false;
        }

        private void Create()
        {
            ProductPrice productPrice = new ProductPrice();
            productPrice.PriceName = txtName.Text;
            productPrice.Price = txtPrice != null ? decimal.Parse(txtPrice.Text) : 0;
            productPrice.ActiveDate = dtpActiveDate.Value;
            productPrice.Active = cbActive.Checked == true ? true : false;
            productPrice.Note = txtNote.Text;
            //productPrice.ProductId = cbbProdCode.SelectedValue.ToString();
            productPrice.CreateBy = UserManagement.UserSession.UserName;
            productPrice.CreateDate = DateTime.Now;
            try
            {
                db.Execute("insert into ProductPrice(Name,ProductId,Price,ActiveDate,Active,UnitId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values(@Name,@ProductId,@Price,@ActiveDate,@Active,@UnitId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)",productPrice);
            }
            catch
            {
                FlatMessageBox.FlatMsgBox.Show("Không thẻ lưu");
                return;
            }
        }
        private void Edit(ProductPrice price)
        {
            if (price.PriceId <= 0) return;
            price.PriceName = txtName.Text;
            price.Price = txtPrice != null ? decimal.Parse(txtPrice.Text) : 0;
            price.ActiveDate = dtpActiveDate.Value;
            price.Active = cbActive.Checked == true ? true : false;
            price.Note = txtNote.Text;
            price.ModifyBy = UserManagement.UserSession.UserName;
            price.ModifyDate = DateTime.Now;
            try
            {
                db.Execute("update ProductPrice set Name = @Name,Price = @Price,ActiveDate = @ActiveDate,Active=@Active,Note=@Note,ModifyDate = @ModifyDate,ModifyBy=@ModifyBy where Id =@Id", price);
            }
            catch
            {
                FlatMessageBox.FlatMsgBox.Show("Không thẻ lưu");
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_Price == null)
            {
                if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    FlatMessageBox.FlatMsgBox.Show("Giá không được để trống");
                    return;
                }
                Create();
            }
            else
            {
                Edit(m_Price);
            }
        }

        private void cbbProdCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbProdCode.SelectedValue!=null)
            {
                txtProductName.Text = ((Product)cbbProdCode.SelectedItem).ProductCode;
            }
        }
    }
}
