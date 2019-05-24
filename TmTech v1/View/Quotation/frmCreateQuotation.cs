using DevExpress.XtraGrid.Columns;
using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateQuotation : MetroForm
    {
        Company m_Company;
        Quotation m_Quotation;
        GridUtility gridUtility = new GridUtility();
        
        bool isEdited = false;

        public frmCreateQuotation()
        {
            InitializeComponent();
            IInitColumn quotationDetailColumn = new QuotationDetailColumn(gridView1, checkBoxCombobox1);
            List<GridColumn> lstDefinedColumn = new List<GridColumn>() { colDimension, colDonvi };
            gridUtility = new GridUtility(gridControl1,false,false,35,colDescription);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridUtility.ColDimensionPicture = colDimension;
            gridUtility.ColDimensionPicturePath = colDimensionPath;
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            m_Quotation = new Quotation();
            m_Company = null;
            gridView1.RowHeight = 150;
            this.checkBoxCombobox1.CheckStateChanged += new System.EventHandler(this.checkComboBox1_CheckStateChanged);
            quotationDetailColumn.InitColumn(lstDefinedColumn);
        }

        private void checkComboBox1_CheckStateChanged(object sender, EventArgs e)
        {

            CheckComboBoxItem  checkboxitem =  sender as CheckComboBoxItem;
            foreach(DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                if (column.FieldName == checkboxitem.Value)
                {
                    column.Visible = checkboxitem.CheckState;
                    return;
                }
            }
        }

        private void InitializeForm(Quotation quotation)
        {
            if (quotation == null) return;
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel1, quotation);
            if (m_Company != null)
            {
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel1, m_Company);
                if (m_Company.MainDeputy == null) m_Company.MainDeputy = new Deputy();
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel1, m_Company.MainDeputy);
            }
            //m_Quotation.Company = m_Company;
        }
        private void cbbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_Company = cbbCompany.SelectedItem as Company;
            if (m_Company == null) return;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Quotation.QuotationCode = uow.QuotationRepository.GetQuotationCode(m_Company.CompanyId, DateTime.Today);
                uow.Commit();
            }

            m_Quotation.Company = m_Company;
            m_Quotation.CusId = m_Company.CompanyId;
            InitializeForm(m_Quotation);
        }
        private void frmCreateQuotation_Load(object sender, EventArgs e)
        {
            Utility.ComboboxUtility.BindCompany(cbbCompany);
            cbbCompany.SelectedValue = -1;        
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadGrid(QuotationDetail quotationDetail)
        {
            IList<QuotationDetail> lstOrigin = gridControl1.DataSource as IList<QuotationDetail>;
            if (lstOrigin == null) lstOrigin = new List<QuotationDetail>();
            lstOrigin.Add(quotationDetail);
            gridUtility.BindingData<QuotationDetail>(lstOrigin);
            //gridUtility.AddNewRow<QuotationDetail>(quotationDetail);
            isEdited = true;
        }
        private void btnLookForProduct_Click(object sender, EventArgs e)
        {
            if (m_Company == null)
            {
                lblNotify1.SetText(UI.hasnotcompanyselected, LabelNotify.EnumStatus.Failed);
                return;
            }
            frmAddProductToQuotation frmSelectProduct = new frmAddProductToQuotation(m_Company);
            frmSelectProduct.AddtoGrid = LoadGrid;
            Hide();
            frmSelectProduct.ShowDialog();
            Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            Product product = gridView1.GetRow(i) as Product;
            if (product == null) return;
        }

        
        public delegate void delgAddRow(Quotation quotation,CRUD crud);
        public delgAddRow AddRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) 
                return;
            if(m_Quotation==null) return;
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel1, m_Quotation);
            IList<QuotationDetail> lstQuottionDetail = gridControl1.DataSource as IList<QuotationDetail>;
            if (lstQuottionDetail == null)
                return;
            
            m_Quotation.Company = m_Company;
            m_Quotation.TotalValue = CurrencyUtility.ToDecimal(colThanhtien.SummaryText);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.QuotationRepository.Add(m_Quotation);
                    foreach (QuotationDetail quotationDetail in lstQuottionDetail)
                    {
                        quotationDetail.QuotationCode = m_Quotation.QuotationCode;
                        uow.QuotationDetailRepository.Add(quotationDetail);
                    }
                    uow.Commit();  
                }
                if (AddRow != null)
                {
                    AddRow(m_Quotation, CRUD.Insert);
                }
                lblNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                //();
                isEdited = false;
                this.Close();

            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FormUtility.MsgDelete();
            if (dialogResult == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                QuotationDetail detail = gridView1.GetRow(i) as QuotationDetail;
                if (detail != null)
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.QuotationDetailRepository.Remove(detail);
                        uow.Commit();
                    }
                }
                gridView1.DeleteRow(i);
            }
            else
            {
                return;
            }
        }

        private void frmCreateQuotation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdited == true)
            {
                DialogResult result = FormUtility.CloseWithoutSave();
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            IList<QuotationDetail> lstQuotationdetail = gridControl1.DataSource as IList<QuotationDetail>;
            if (lstQuotationdetail == null || lstQuotationdetail.Count == 0)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.QuotationRepository.DeleteNullQuotation(m_Quotation);
                    uow.Commit();
                }
            }
            List<string> lstcolumnChecked = new List<string>();
            foreach (CheckComboBoxItem item in checkBoxCombobox1.Items)
            {
                if (item.CheckState == true)
                    lstcolumnChecked.Add(item.Value);
            }
            UtilityFunction.WriteColumnToshow(lstcolumnChecked);
        }

        private void cbbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbbCompany_SelectionChangeCommitted(null, e);
            }
        }
        private void UpdateRow(QuotationDetail quotationDetail)
        {
            gridUtility.UpdateRow<QuotationDetail>(quotationDetail);
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            QuotationDetail quotationDetail = gridView1.GetRow(i) as QuotationDetail;
            if (quotationDetail == null) return;
            frmEditProductProperties frmEdit = new frmEditProductProperties(quotationDetail, quotationDetail.Product, m_Company);
            frmEdit.UpdateRow = UpdateRow;
            frmEdit.ShowDialog();
            gridView1.RefreshData();
        }

    }
}