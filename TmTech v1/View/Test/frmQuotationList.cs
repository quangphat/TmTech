using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Test
{
    public partial class frmQuotationList : UserControl
    {
        
        public frmQuotationList()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            FormUtility.FormatForm(this);
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
            customGridControl1.BindingData<Quotation>(lstQuotation);
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
                //GridUtility.AddNewRow<Quotation>( quotation);
            }
            if (crud == CRUD.Update)
            {
                //GridUtility.UpdateRow<Quotation>( quotation);
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
            //if (quotation == null) return;
            //int i = gridView1.GetSelectedRows().FirstOrDefault();
            //GridUtility.UpdateRow<Quotation>( i, quotation);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ////int i = gridView1.GetSelectedRows()[0];
            ////Quotation quotation = gridView1.GetRow(i) as Quotation;
            ////if (quotation == null) return;
            ////frmEditQuotation frmEdit = new frmEditQuotation(quotation);
            ////frmEdit.UpdateRow = UpdateRow;
            ////frmEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ////int i = gridView1.GetSelectedRows()[0];
            ////Quotation quotation = gridView1.GetRow(i) as Quotation;
            ////if (quotation == null) return;
            ////DialogResult result = FormUtility.MsgDelete();
            ////if (result == DialogResult.No)
            ////    return;
            ////try
            ////{
            ////    using (IUnitOfWork uow = new UnitOfWork())
            ////    {
            ////        uow.QuotationRepository.DeleteNullQuotation(quotation);
            ////        uow.Commit();
            ////    }
            ////    gridView1.DeleteRow(i);
            ////}
            ////catch
            ////{
            ////    lblNotify1.SetText(MesgBox.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            ////}
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
            //GridUtility.BindingData<Quotation>( lstQuotation);
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
    }
}
