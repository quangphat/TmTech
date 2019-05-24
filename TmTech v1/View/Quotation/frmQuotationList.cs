using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech_v1.ToolBoxCS;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmQuotationList : UserControl
    {
        GridUtility gridUtility;
        
        public frmQuotationList()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            FormUtility.FormatForm(this);
            txtSearch.Select();
            IGridviewContextMenu ctxMenu = new QuotationContextMenu();
            gridUtility = new GridUtility(gridControl1,ctxMenu);
            gridUtility.AllowDelete = true;
            lblNotify1.Text = "";
        }

        private void frmQuotationList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            DateTime fromDate = UtilityFunction.GetDatetime(dtpFromDate);
            DateTime toDate = UtilityFunction.GetDatetime(dtpTodate);
            IList<Quotation> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.QuotationRepository.LookByDate(fromDate, toDate);
                uow.Commit();
            }
            gridUtility.BindingData<Quotation>(lstQuotation);
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dtpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadGrid();
            }

        }

        private void dtpTodate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadGrid();
            }
        }

        private void AddOrUpdateRow(Quotation quotation, CRUD crud)
        {
            if (quotation == null) return;
            if (crud == CRUD.Insert)
            {
                gridUtility.AddNewRow<Quotation>( quotation);
            }
            if (crud == CRUD.Update)
            {
                gridUtility.UpdateRow<Quotation>( quotation);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateQuotation frmCreate = new frmCreateQuotation();
            frmCreate.AddRow = AddOrUpdateRow;
            frmCreate.ShowDialog();
            //frmSelectCompany objSelect = new frmSelectCompany(WhichForm.FromForm.QuotationForm);
            //objSelect.ShowDialog();
            //LoadGrid();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void UpdateRow(Quotation quotation)
        {
            if (quotation == null) return;
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            gridUtility.UpdateRow<Quotation>( i, quotation);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Quotation quotation = gridView1.GetRow(i) as Quotation;
            if (quotation == null) return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                quotation.Company = uow.CompanyRepository.Find(quotation.CusId);
                uow.Commit();
            }
            frmEditQuotation frmEdit = new frmEditQuotation(quotation);
            frmEdit.UpdateRow = UpdateRow;
            frmEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Quotation quotation = gridView1.GetRow(i) as Quotation;
            if (quotation == null) return;
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.No)
                return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.QuotationRepository.DeleteNullQuotation(quotation);
                    uow.Commit();
                }
                gridView1.DeleteRow(i);
            }
            catch
            {
                lblNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Search(txtSearch.Text);
            }
        }
        private void Search(string searchStr)
        {
            if (string.IsNullOrWhiteSpace(searchStr)) return;
            IList<Quotation> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.QuotationRepository.Search(searchStr);
                uow.Commit();
            }
            gridUtility.BindingData<Quotation>( lstQuotation);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Quotation quotation = e.Row as Quotation;
            //if (quotation == null) return;
            //using (IUnitOfWork uow = new UnitOfWork())
            //{
            //    if (uow.QuotationRepository.CodeExists(quotation) == false)
            //    {
            //        uow.QuotationRepository.Update(quotation);
            //    }
            //    else
            //    {
            //        lblNotify1.SetText(MesgBox.codehasexist, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            //        GridUtility.UpdateRow<Quotation>( quotation);
            //    }
            //    uow.Commit();
            //}
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    int i = gridView1.GetSelectedRows().FirstOrDefault();
            //    gridView1_RowUpdated(sender, new DevExpress.XtraGrid.Views.Base.RowObjectEventArgs(i,gridView1.GetRow(i)));
            //}
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility.DrawStatusColor(sender, e, colStatus, colCode);
        }
    }
}
