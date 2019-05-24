using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.Model;
namespace TmTech_v1.View
{
    public partial class frmAddProductToQuotation : Form
    {
        frmSelectProduct frmProduct;
        frmSelecteProperties frmSelectProperty;
        Company m_Company;
        public enum PnlToShow {pnlProduct =1,pnlProperty = 2};
        public frmAddProductToQuotation(Company company)
        {
            InitializeComponent();
            pnlProduct.Width += pnlProperty.Width;
            pnlProperty.Width = 0;
            m_Company = company;
            ShowPnl(PnlToShow.pnlProduct);
            frmProduct = new frmSelectProduct();
            frmProduct.ShowProperty = ShowProperty;
            productPath1.Visible = false;
        }
        private void HideProperty()
        {
            ShowPnl(PnlToShow.pnlProduct);
        }
        private void ShowProperty(Model.Product product)
        {
            ShowPnl(PnlToShow.pnlProperty,product);
            productPath1.Visible = true;
            productPath1.Show(product);
            productPath1.SearchByName = Search;
        }
        private void ShowPnl(PnlToShow pnlToshow,Model.Product product=null)
        {
            if (pnlToshow == PnlToShow.pnlProduct)
            {
                //this.pnlProperty.Width = 0;
                pnlProperty.Hide();
                pnlProduct.Show();
            }
            if (pnlToshow == PnlToShow.pnlProperty)
            {
                pnlProperty.Width = pnlProduct.Width;
                pnlProperty.Location = new Point(pnlProduct.Location.X, pnlProperty.Location.Y);
                pnlProduct.Hide();
                frmSelectProperty = new frmSelecteProperties(product,m_Company);
                frmSelectProperty.SaveSelectedProperty = SaveSelectedProperty;
                frmSelectProperty.HideThis = HideProperty;
                //frmSelectProperty.m_Product = product;
                pnlProperty.Controls.Clear();
                pnlProperty.Controls.Add(frmSelectProperty);
                pnlProperty.Show();
            }
        }
        public delegate void delgAddToGrid(Model.QuotationDetail quotationDetail);
        public delgAddToGrid AddtoGrid;
        private void SaveSelectedProperty(Model.QuotationDetail quotationDetail)
        {
            if (AddtoGrid != null)
                AddtoGrid(quotationDetail);
        }
        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            LoadTree();
            pnlProduct.Controls.Add(frmProduct);
            
        }
        public void LoadTree()
        {
            ProductUtility ProductUtility = new ProductUtility(treeView1);
            ProductUtility.BuildRoot();
            if (treeView1.Nodes != null)
            {
                treeView1.Nodes[0].Checked = true;
            }
        }
        private void SetPath(TreeNode node)
        {
            
        }

        private void pnlRight_Click(object sender, EventArgs e)
        {
            
        }


        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;
            Search(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;
            if(e.KeyCode == Keys.Return)
                Search(txtSearch.Text);
        }
        private void Search(string searchStr)
        {
            
            IList<Model.Product> lstProduct;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.ProductRepository.FindByName(searchStr);
                uow.Commit();
            }
            frmProduct.BindProductToListView(lstProduct);
            ShowPnl(PnlToShow.pnlProduct);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;
            TreeTag treeTag = e.Node.Tag as TreeTag;
            treeView1.SelectedNode = e.Node;
            IList<Model.Product> lstProduct = null;
            e.Node.Expand();
            if (e.Button == MouseButtons.Left)
            {
                if (treeTag == null) return;
                lstProduct = ProductUtility.FindProductByParent(treeTag);
            }
            frmProduct.BindProductToListView(lstProduct);
            ShowPnl(PnlToShow.pnlProduct);
        }
    }
}
