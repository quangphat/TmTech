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
    public partial class frmCreatePo : MetroForm
    {
        Company m_Comapny;
        Po m_Po;
        GridUtility gridUtility;

        public frmCreatePo()
        {
            InitializeComponent();
            IInitColumn quotationDetailColumn = new QuotationDetailColumn(gridView1, checkBoxCombobox1);
            List<GridColumn> lstDefinedColumn = new List<GridColumn>() { colDimension, colDonvi };
            gridUtility = new GridUtility(gridControl1, false, false, 35, colDescription);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridUtility.ColDimensionPicture = colDimension;
            gridUtility.ColDimensionPicturePath = colDimensionPath;
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            gridView1.RowHeight = 150;
            isEdited = false;
            m_Po = new Po();
            m_Po.CreateDebt = true;
            m_Comapny = new Company();
            quotationDetailColumn.InitColumn(lstDefinedColumn);
        }

        private void frmCreatePo_Load(object sender, EventArgs e)
        {
            //SetTextboxReadOnly(true);

            InitializeForm(m_Po);
        }
        private void InitializeForm(Po po)
        {
            if (po == null) return;
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, po);
            if (po.Quotation != null)
            {
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, po.Quotation);
            }
            if (m_Comapny != null)
            {
                CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, m_Comapny);
                if (m_Comapny.MainDeputy != null)
                {
                    CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel3, m_Comapny.MainDeputy);

                }
                if (m_Comapny.CompanyId > 0)
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        m_Po.PoCode = uow.PoRepository.GetPOCode(m_Comapny.CompanyId, DateTime.Today);
                        uow.Commit();
                    }
                    txtPoCode.Text = m_Po.PoCode;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            IList<Product> lstProduct = gridControl1.DataSource as IList<Product>;
            if (m_Po != null && (lstProduct == null || lstProduct.Count <= 0))
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PoRepository.Remove(m_Po);
                    uow.Commit();
                }
            }
            Close();
        }


        private void btnLookForProduct_Click(object sender, EventArgs e)
        {
            frmLookForProduct frmLook = new frmLookForProduct();
            frmLook.AddProductToGrid = AddProductToGrid;
            frmLook.Show();
        }
        private void AddProductToGrid(IList<CustomModel.CustomProduct> lstProduct)
        {
            ProductUtility.AddProductToGrid(lstProduct, gridControl1);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }


        public delegate void delgAddRow(Po po, CRUD flag);
        public delgAddRow AddRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            IList<QuotationDetail> lstProduct = gridControl1.DataSource as IList<QuotationDetail>;
            if (m_Po == null) return;
            if (lstProduct == null) return;
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel3, m_Po);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PoRepository.Add(m_Po);
                    uow.Commit();
                }
                isEdited = false;
                lblNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                if (AddRow != null)
                {
                    m_Po.Quantity = Convert.ToInt32(colQuantity.SummaryText);
                    m_Po.TotalValue = CurrencyUtility.ToDecimal(colThanhtien.SummaryText);
                    AddRow(m_Po, CRUD.Insert);
                }
                Close();
            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }

        }

        private void btnLoadQuotation_Click(object sender, EventArgs e)
        {
            frmLookForQuotation frmLookQuotation = new frmLookForQuotation();
            frmLookQuotation.GetAllProduct = LoadGrid;
            frmLookQuotation.ShowDialog();
        }
        bool isEdited;
        private void LoadGrid(IList<QuotationDetail> lstQuotationDetail, Quotation quotation)
        {
            gridUtility.BindingData<QuotationDetail>(lstQuotationDetail);
            m_Po.Quotation = quotation;
            m_Comapny = quotation.Company;
            m_Po.CompanyId = m_Comapny.CompanyId;
            m_Po.Company = m_Comapny;
            m_Po.QuotationCode = quotation.QuotationCode;
            m_Po.CreateDebt = true;
            InitializeForm(m_Po);
            isEdited = true;
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

        private void frmCreatePo_FormClosing(object sender, FormClosingEventArgs e)
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
            if (lstQuotationdetail == null || lstQuotationdetail.Count == 0 || isEdited == true)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PoRepository.Remove(m_Po.PoCode);
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

        private void autoTextBox1_TextChanged(object sender, EventArgs e)
        {
            double percent = string.IsNullOrWhiteSpace(autoTextBox1.Text) == true ? 0 : Convert.ToDouble(autoTextBox1.Text);
            autoTextBox15.Text = CurrencyUtility.DecimalToString(CurrencyUtility.PercentToMoney(percent / 100, colThanhtien.SummaryText));
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
