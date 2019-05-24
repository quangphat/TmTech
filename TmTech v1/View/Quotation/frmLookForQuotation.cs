using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Interface;
namespace TmTech_v1.View
{
    public partial class frmLookForQuotation : MetroForm
    {
        Model.Company m_Company;
        GridUtility gridUtility;
        public frmLookForQuotation()
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            gridUtility = new GridUtility(gridControl1);
        }
        public frmLookForQuotation(Model.Company company)
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            gridUtility = new GridUtility(gridControl1);
            m_Company = company;
        }
        private void frmLookForQuotation_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            List<Model.Quotation> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (m_Company == null)
                    lstQuotation = uow.QuotationRepository.Search(txtSearch.Text);
                else
                    lstQuotation = uow.QuotationRepository.LookByCompany(m_Company);
                uow.Commit();
            }
            gridUtility.BindingData<Model.Quotation>( lstQuotation);
        }
        public void LoadByTime()
        {
            DateTime fromDate = UtilityFunction.GetDatetime(dtpFromDate);
            DateTime toDate = UtilityFunction.GetDatetime(dtpTodate);
            List<Model.Quotation> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.QuotationRepository.LookByDate(fromDate, toDate);
                uow.Commit();
            }
            gridUtility.BindingData<Model.Quotation>(lstQuotation);
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
        public delegate void delgGetAllProduct(IList<Model.QuotationDetail> lstProduct,Model.Quotation quotation);
        public delgGetAllProduct GetAllProduct;
        //public delegate void delgBindCompany(int companyId);
        //public delgBindCompany BindCompany;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            IList<Model.QuotationDetail> lstProduct;
            Model.Quotation quotation = gridUtility.GetSelectedItem<Model.Quotation>() as Model.Quotation;
            if (quotation == null) return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstProduct = uow.QuotationDetailRepository.Find(quotation);
                uow.Commit();
            }
            if (GetAllProduct != null)
                GetAllProduct(lstProduct,quotation);
            Close();
        }

        private void frmLookForQuotation_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadByTime();
        }
    }
}
