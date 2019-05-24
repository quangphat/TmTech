using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmProductPrice : MetroForm,IFormBase
    {
        Product m_Product;
        List<ProductPrice> m_lstRowUpdated;
        GridUtility gridUtility;
        public frmProductPrice()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
            m_lstRowUpdated = new List<ProductPrice>();
        }
        public frmProductPrice(Product productSearch)
        {
            InitializeComponent();
            m_Product = productSearch;
            txtSearch.Text = productSearch.ProductCode;
            m_lstRowUpdated = new List<ProductPrice>();
            gridUtility.FormatDisplay();
        }

        public delegate void delgUpdatePrice(Product product);
        public delgUpdatePrice UpdatePrice;
        private void frmProductPrice_Load(object sender, EventArgs e)
        {
            LoadGrid();
            AllowColEdit(false);
        }
        public void LoadGrid()
        {
            IList<ProductPrice> lstProductPrice;
            if (ValidationUtility.StringIsNull(txtSearch.Text)) m_Product = new Product();
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstProductPrice = uow.ProductPriceRepository.FindByProduct(txtSearch.Text);
                uow.Commit();
            }
            gridUtility.BindingData<ProductPrice>( lstProductPrice);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
            {
                LoadGrid();
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if(btnEditSave.Status == ToolBoxCS.ButtonEditSave.ButtonStatus.Edit)
            {
                AllowColEdit(true);
                btnEditSave.Status = ToolBoxCS.ButtonEditSave.ButtonStatus.Save;
            }
            else
            {
                
                if(m_lstRowUpdated!=null)
                {
                    using(IUnitOfWork uow = new UnitOfWork())
                    {
                        foreach (ProductPrice price in m_lstRowUpdated)
                        {
                            price.ProductId = m_Product.ProductId;
                            price.CreateBy = UserManagement.UserSession.UserName;
                            price.PriceId  = uow.ProductPriceRepository.Update(price);
                            gridView1.SetRowCellValue(gridView1.GetSelectedRows().FirstOrDefault(), colPriceId, price.PriceId);
                        }
                        m_Product = uow.ProductRepository.Find(m_Product.ProductId);
                        uow.Commit();
                    }
                    m_lstRowUpdated = null;
                }
                if (UpdatePrice != null)
                    UpdatePrice(m_Product);
                btnEditSave.Status = ToolBoxCS.ButtonEditSave.ButtonStatus.Edit;
                AllowColEdit(false);
            }
        }
        private void AllowColEdit(bool editable)
        {
            colActiveDate.OptionsColumn.AllowEdit = editable;
            colPrice.OptionsColumn.AllowEdit = editable;
        }

        public void SetTextboxReadOnly(bool isReadOnly)
        {
            throw new NotImplementedException();
        }

        void IFormBase.SetFormEnable(bool enable)
        {
            throw new NotImplementedException();
        }


        public void EnableCtrl(bool enable)
        {
            throw new NotImplementedException();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (m_lstRowUpdated == null)
                m_lstRowUpdated = new List<ProductPrice>();
            ProductPrice price = e.Row as ProductPrice;
            if (price != null)
                m_lstRowUpdated.Add(price);
        }
    }
}
