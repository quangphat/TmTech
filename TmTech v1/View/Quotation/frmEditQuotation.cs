using DevExpress.XtraGrid.Columns;
using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.CustomModel;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditQuotation : MetroForm
    {
        Quotation m_Quotation;
        Company m_Company;
        GridUtility gridUtility;
        
        public frmEditQuotation(Quotation quotation)
        {
            InitializeComponent();
            IInitColumn quotationDetailColumn = new QuotationDetailColumn(gridView1, checkBoxCombobox1);
            gridUtility = new GridUtility(gridControl1,false,false,35,colDescription);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridUtility.ColDimensionPicture = colDimension;
            gridUtility.ColDimensionPicturePath = colDimensionPath;
            List<GridColumn> lstDefinedColumn = new List<GridColumn>() { colDimension,colDonvi};
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            m_Company = null;
            m_Quotation = quotation;
            m_Company = m_Quotation.Company;
            gridView1.RowHeight = 150;
            isEdited = false;
            this.checkBoxCombobox1.CheckStateChanged += new System.EventHandler(this.checkComboBox1_CheckStateChanged);
            quotationDetailColumn.InitColumn(lstDefinedColumn);
        }
        private void checkComboBox1_CheckStateChanged(object sender, EventArgs e)
        {

            CheckComboBoxItem checkboxitem = sender as CheckComboBoxItem;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                if (column.FieldName == checkboxitem.Value)
                {
                    column.Visible = checkboxitem.CheckState;
                    return;
                }
            }
            
        }
        private void frmEditQuotation_Load(object sender, EventArgs e)
        {
            IList<QuotationDetail> lstQuotationDetail;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotationDetail = uow.QuotationDetailRepository.Find(m_Quotation);
                m_Company = uow.CompanyRepository.Find(m_Company.CompanyId);
                uow.Commit();
            }
            InititalizeForm(m_Quotation);
            gridUtility.BindingData<QuotationDetail>(lstQuotationDetail);
        }
        bool isEdited;
        private void LoadGrid(QuotationDetail quotationDetail)
        {
            IList<QuotationDetail> lstOrigin = gridControl1.DataSource as IList<QuotationDetail>;
            if (lstOrigin == null) lstOrigin = new List<QuotationDetail>();
            lstOrigin.Add(quotationDetail);
            gridUtility.BindingData<QuotationDetail>(lstOrigin);
            isEdited = true;
        }
        private void InititalizeForm(Quotation quotation)
        {
            if (quotation == null) return;
            CoverObjectUtility.SetAutoBindingData(this, quotation);
            if(quotation.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                colQuantity.OptionsColumn.AllowEdit = false;
                foreach (GridColumn col in gridView1.Columns)
                {
                    col.OptionsColumn.AllowEdit = false;
                }
                btnRemove.Visible = false;
                txtQuotationCode.ReadOnly = true;
                txtQuotationCode.Display(quotation.ApproveStatusId);
            }
            if (m_Company != null)
            {
                if (m_Company.MainDeputy == null)
                    m_Company.MainDeputy = new Deputy();
                CoverObjectUtility.SetAutoBindingData(this, m_Company);
            }
        }
        private void AddProductToGrid(IList<CustomProduct> lstProduct)
        {
            ProductUtility.AddProductToGrid(lstProduct, gridControl1);
            gridView1.RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = FormUtility.MsgDelete();
            if(dialogResult ==DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                QuotationDetail detail = gridView1.GetRow(i) as QuotationDetail;
                if (detail!=null)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public delegate void delgUpdateRow(Quotation quotation);
        public delgUpdateRow UpdateRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            if (m_Quotation == null) 
                return;
            CoverObjectUtility.GetAutoBindingData(this, m_Quotation);
            if(m_Quotation.ApproveStatusId==(int)ApproveStatus.Approved)
            {
                lblNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Quotation.SetModify();
            IList<QuotationDetail> lstQuotationDetail = gridControl1.DataSource as IList<QuotationDetail>;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.QuotationRepository.Update(m_Quotation);
                    foreach (QuotationDetail p in lstQuotationDetail)
                    {
                        p.QuotationCode = m_Quotation.QuotationCode;
                        if (p.QuotationDetailId != Guid.Empty)
                            uow.QuotationDetailRepository.Update(p);
                        else
                            uow.QuotationDetailRepository.Add(p);
                    }
                    uow.Commit();
                }
                m_Quotation.TotalValue = CurrencyUtility.ToDecimal(colThanhtien.SummaryText);
                isEdited = false;
                if (UpdateRow != null)
                    UpdateRow(m_Quotation);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void btnLookForProduct_Click_1(object sender, EventArgs e)
        {
            if (m_Company == null)
            {
                lblNotify1.SetText(UI.hasnotcompanyselected, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            frmAddProductToQuotation frmSelectProduct = new frmAddProductToQuotation(m_Company);
            frmSelectProduct.AddtoGrid = LoadGrid;
            Hide();
            frmSelectProduct.ShowDialog();
            Show();
        }

        private void frmEditQuotation_FormClosing(object sender, FormClosingEventArgs e)
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
            List<string> lstcolumnChecked = new List<string>();
            foreach (CheckComboBoxItem item in checkBoxCombobox1.Items)
            {
                if (item.CheckState == true)
                    lstcolumnChecked.Add(item.Value);
            }
            UtilityFunction.WriteColumnToshow(lstcolumnChecked);
        }

        private void UpdateDetailRow(QuotationDetail quotationDetail)
        {
            gridUtility.UpdateRow<QuotationDetail>(quotationDetail);
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            QuotationDetail quotationDetail = gridView1.GetRow(i) as QuotationDetail;
            if (quotationDetail == null) return;
            quotationDetail.Product.Quantity = quotationDetail.Quantity;
            quotationDetail.Quotation = m_Quotation;
            frmEditProductProperties frmEdit = new frmEditProductProperties(quotationDetail, quotationDetail.Product, m_Company);
            frmEdit.UpdateRow = UpdateDetailRow;
            Hide();
            frmEdit.ShowDialog();
            Show();
            gridView1.RefreshData();
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {

            var data = gridControl1.DataSource as IList<QuotationDetail>;
            if (data == null || data.Count <1)
                return;
            var data2 = new List<QuotationDetail>(data);
            var data1 = data[0];
            for( int i =0 ; i<10; i++)
            {
                data2.Add(data1);
            }
            Report.Reportmain report = new Report.Reportmain();
            IReportUtility ireprot = new ReportUtility(report);
            ireprot.Binding(report.bindingSource1, data2);
            ireprot.ShowPreview();
          
        }
    }
}
