using DevExpress.XtraGrid.Columns;
using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditPO : MetroForm
    {
        Po m_Po;
        Company m_Company;
        bool isEdited;
        GridUtility gridUtility;
        
        public frmEditPO(Po po)
        {
            InitializeComponent();
            IInitColumn quotationDetailColumn = new QuotationDetailColumn(gridView1, checkBoxCombobox1);
            List<GridColumn> lstDefinedColumn = new List<GridColumn>() { colDimension, colDonvi };
            gridUtility = new GridUtility(gridControl1, false, false,35, colDescription);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridUtility.ColDimensionPicture = colDimension;
            gridUtility.ColDimensionPicturePath = colDimensionPath;
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            m_Company = po.Company;
            m_Po = po;
            gridView1.RowHeight = 150;
            isEdited = false;
            quotationDetailColumn.InitColumn(lstDefinedColumn);
        }
        private void frmEditPO_Load(object sender, EventArgs e)
        {
            LoadGrid();
            InitializeForm(m_Po);
            InitializeForm(m_Company);
        }
        private void LoadGrid()
        {
            IList<QuotationDetail> lstProduct;
            m_Po.Quotation = new Quotation();
            m_Po.Quotation.QuotationCode = m_Po.QuotationCode;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Po.Quotation = uow.QuotationRepository.Find(m_Po.QuotationCode);
                m_Company = uow.CompanyRepository.Find(m_Po.CompanyId);
                lstProduct = uow.QuotationDetailRepository.Find(m_Po.Quotation);
                uow.Commit();
            }
            gridUtility.BindingData<QuotationDetail>( lstProduct);
        }
        private void InitializeForm(Po po)
        {
            if (po == null) return;
            if(po.ApproveStatusId==(int)ApproveStatus.Approved || po.ApproveStatusId == (int)ApproveStatus.Cancel)
            {
                btnApprove.Visible = btnCancelPO.Visible = btnLoadQuotation.Visible = false;
            }
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, po);
            txtPoCode.Display(po.ApproveStatusId);
            if (po.Quotation != null)
            {
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, po.Quotation);
            }
        }
        private void InitializeForm(Company company)
        {
            if (company == null) return;
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, company);
            if (company.MainDeputy != null)
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, company.MainDeputy);
        }
        private void btnLoadQuotation_Click(object sender, EventArgs e)
        {
            frmLookForQuotation frmLookQuotation = new frmLookForQuotation(m_Company);
            frmLookQuotation.GetAllProduct = LoadGrid;
            frmLookQuotation.ShowDialog();
        }

        private void LoadGrid(IList<QuotationDetail> lstQuotationDetail, Quotation quotation)
        {
            gridUtility.BindingData<QuotationDetail>( lstQuotationDetail);
            m_Po.Quotation = quotation;
            m_Po.QuotationCode = quotation.QuotationCode;
            InitializeForm(m_Po);
            isEdited = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public delegate void delgUpdateRow(Model.Po PO,CRUD flag);
        public delgUpdateRow UpdateRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_Po.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                lblNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed,5000);
                return;
            }
            if (ValidationUtility.FieldNotAllowNull(this.tableLayoutPanel3) == false) return;
            if (m_Po == null) return;
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel3, m_Po);
            m_Po.Quantity = Convert.ToInt32(colQuantity.SummaryText);
            m_Po.TotalValue = CurrencyUtility.ToDecimal(colThanhtien.SummaryText);
            m_Po.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PoRepository.Update(m_Po);
                    uow.Commit();
                }
                lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                isEdited = false;
                if (UpdateRow != null)
                    UpdateRow(m_Po,CRUD.Update);
            }
            catch
            {
                lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void frmEditPO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdited == true)
            {
                DialogResult result = FormUtility.CloseForm();
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
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

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }
        private void btnApprove_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgApprove();
            if (result == System.Windows.Forms.DialogResult.No) return;
            if (m_Po.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                lblNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            //create delivery.
            Delivery delivery = new Delivery();
            delivery.SetCreate();
            delivery.POCode = m_Po.PoCode;
            delivery.CompanyId = m_Company.CompanyId;
            //update po
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel3, m_Po);

            //create debt

            Debt debt = new Debt();
            debt.POCode = m_Po.PoCode;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    delivery.DeliveryCode = uow.DeliveryRepository.CreateCode(m_Company, DateTime.Today);
                    uow.DeliveryRepository.Add(delivery);
                    if (m_Po.CreateDebt == true)
                    {
                        debt.DeliveryCode = delivery.DeliveryCode;
                        uow.DebtRepository.Add(debt);
                    }
                    m_Po.ApproveStatusId = (int)ApproveStatus.Approved;
                    m_Po.ApproveBy = UserManagement.UserSession.UserName;
                    m_Po.ApproveDate = DateTime.Now;
                    Quotation quotation = new Quotation();
                    quotation.ApproveStatusId = (int)ApproveStatus.Approved;
                    quotation.QuotationCode = m_Po.QuotationCode;
                    uow.PoRepository.Update(m_Po);
                    uow.QuotationRepository.Lock(quotation);
                    uow.PlanningRepository.CreateFromPO(m_Po);
                    LogUtility.WriteLog(m_Po.PoCode, m_Po.ApproveStatusId,uow);
                    uow.Commit();
                }
                txtPoCode.Display(m_Po.ApproveStatusId);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                InitializeForm(m_Po);
            }
            catch 
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCancelPO_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.CancelApprove();
            if (result == System.Windows.Forms.DialogResult.No) return;
            m_Po.ApproveStatusId = (int)ApproveStatus.Cancel;
            m_Po.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PoRepository.Update(m_Po);
                    LogUtility.WriteLog(m_Po.PoCode, m_Po.ApproveStatusId, uow);
                    uow.Commit();
                }
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                txtPoCode.Display(m_Po.ApproveStatusId);
                InitializeForm(m_Po);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void autoTextBox1_TextChanged(object sender, EventArgs e)
        {
            double percent = string.IsNullOrWhiteSpace(autoTextBox1.Text) == true ? 0 : Convert.ToDouble(autoTextBox1.Text);
            autoTextBox15.Text = CurrencyUtility.DecimalToString(CurrencyUtility.PercentToMoney(percent / 100,m_Po.TotalValue));
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }
        IReportUtility reportUtility;
        private void btnReport_Click(object sender, EventArgs e)
        {
            rptPoDetail rpt = new rptPoDetail();
            reportUtility = new ReportUtility(rpt);
            IList<QuotationDetail> lstQuotation = gridControl1.DataSource as IList<QuotationDetail>;
            foreach (QuotationDetail detail in lstQuotation)
            {
                detail.TotalDescription = ProductUtility.ConvertToDescription(detail, ProductUtility.QuotationDetailToDescription);
            }
            reportUtility.Binding<QuotationDetail>(rpt.bindingSource1,lstQuotation);
            reportUtility.ShowPreview();
            
        }

    }
}
