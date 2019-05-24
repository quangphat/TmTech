using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Interface;
namespace TmTech_v1.View
{
    public partial class frmLookForPO : MetroForm
    {
        GridUtility gridUtility;
        public frmLookForPO()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmLookForQuotation_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            IList<Model.Po> lstQuotation = Search(txtSearch.Text);
            gridUtility.BindingData<Model.Po>( lstQuotation);
        }
        private List<Model.Po> Search(string searchStr)
        {
            List<Model.Po> lstPO;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPO = uow.PoRepository.Search(txtSearch.Text);
                uow.Commit();
            }
            return lstPO;
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadGrid();
            }
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }
        public delegate void delgGetAllProduct(Model.Po po,IList<Model.Product> lstProduct);
        public delgGetAllProduct GetAllProduct;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            IList<Model.Product> lstProduct;
            Model.Po po = gridUtility.GetSelectedItem<Model.Po>() as Model.Po;
            if (po == null) return;
            po.Quotation = new Model.Quotation();
            po.Quotation.QuotationCode = po.QuotationCode;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.PoRepository.GetAllProduct(po.Quotation);
                uow.Commit();
            }
            if (GetAllProduct != null)
                GetAllProduct(po,lstProduct);
            Close();
        }

        private void frmLookForQuotation_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
