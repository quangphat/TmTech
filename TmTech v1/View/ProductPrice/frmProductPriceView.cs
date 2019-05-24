using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Utility;
using Dapper;
using FlatMessageBox;
using TmTech_v1.Model;
using ModernUI.Controls;

namespace TmTech_v1.View
{
    public partial class frmProductPriceView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        
        public frmProductPriceView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //LoadUser(true,grid);
        }

        public void LoadGrid()
        {
            LoadProduct( metroGrid1);
        }
        private void LoadProduct(MetroGrid gridView)
        {
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            List<ProductPrice> lstProductPrice = new List<ProductPrice>();
            string select = string.Empty;
                select = string.Format(@"select rank() over(order by pr.Id) as Stt,pr.Id as Id,pr.Name,pr.Price,pr.ActiveDate,pr.Active,pr.CreateDate,p.Id, p.Name,p.Code,u.Id,u.UserName from ProductPrice pr
                                            inner join Product p on pr.ProductId = p.Id inner join Users u on pr.CreateBy = u.Id");
                select = @"select rank() over(order by pr.Id) as Stt,pr.Id as Id,pr.Name as Name,pr.Price,pr.ActiveDate,pr.Active,pr.CreateDate,p.Id, p.Name,p.Code,u.Id,u.UserName from ProductPrice pr
                                            inner join Product p on pr.ProductId = p.Id inner join Users u on pr.CreateBy = u.Id where pr.CreateBy = " + UserManagement.UserSession.UserName;

            lstProductPrice = db.Query<ProductPrice, Product, Users, ProductPrice>(select, (pr, p, u) => { pr.Product = p; pr.User = u; return pr; }, splitOn: "Id,Id").ToList();
            if(lstProductPrice!=null)
            {
                BindingSource source = new BindingSource();
                source.DataSource = lstProductPrice;
                gridView.DataSource = null;
                gridView.DataSource = source;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(UserManagement.AllowCreate("ProductPrice")==true)
            {
                frmProductPriceDetail frmCreate = new frmProductPriceDetail();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }
        public delegate void delgSetFormEnable(bool isEnable);
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowEdit("ProductPrice") == true)
            {
                ProductPrice price =null;
                try
                {
                    price = metroGrid1.SelectedRows[0].DataBoundItem as ProductPrice;
                    frmProductPriceDetail frmCreate = new frmProductPriceDetail(price);
                    frmCreate.Show();
                }
                catch { }
                
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền chỉnh sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowDelete("Users") == true)
            {
                DialogResult result = FormUtility.MsgDelete();
                if (result == DialogResult.Yes)
                {
                    //CustomUser user = null;
                    //int selectedrow = grdView.GetSelectedRows().FirstOrDefault();
                    ////if (selectedrow == 0) return;
                    //user = (CustomUser)grdView.GetRow(selectedrow);
                    //if (user == null) return;
                    //bool ok = Database.DeleteById<Users>("delete Users where Id = " + user.Id.ToString());
                    //if (ok == false)
                    //{
                    //    FlatMsgBox.Show("Không thể xóa");
                    //    return;
                    //}
                    //LoadUser(this.isLoadAll, grid);
                }
                else return;
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

    }
}
