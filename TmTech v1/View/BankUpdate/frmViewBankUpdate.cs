using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmViewBankUpdate : UserControl
    {
        GridUtility gridUtility1;
        GridUtility gridUtility2;
        
        public frmViewBankUpdate()
        {
            InitializeComponent();
            gridUtility1 = new GridUtility(gridControl1);
            gridUtility2 = new GridUtility(gridControl2);
        }


        private void frmViewBankUpdate_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            loadDB();
        }

        private void loadDB()
        {
            IList<Model.Bank> lstBank = new List<Model.Bank>();

            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBank = uow.BankBaseRepository.All();
            }

            gridUtility1.BindingData( lstBank);
        }

        private void InsertOrUpdate(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null)
        {
            if (bank != null && branch == null)
            {
                if (cru == CRUD.Insert)
                    gridUtility1.AddNewRow( bank);
                if (cru == CRUD.Update)
                    gridUtility1.UpdateRow(bank);
            }
            if(branch != null && bank != null)
            {
                if (cru == CRUD.Insert)
                    gridUtility2.AddNewRow( branch);
                if (cru == CRUD.Update)
                    gridUtility2.UpdateRow( branch);
            }

        }
        private void btnCreateBank_Click(object sender, EventArgs e)
        {
            frmCreateBankUpdate obj = new frmCreateBankUpdate();
            obj.addnewBank = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridViewBank_DoubleClick(object sender, EventArgs e)
        {
            Model.Bank bank = gridUtility1.GetSelectedItem<Model.Bank>();
            if (bank == null) return;
            frmEditBankUpdate obj = new frmEditBankUpdate(bank);
            obj.updateBank = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridViewBranchBank_DoubleClick(object sender, EventArgs e)
        {
            Model.BrankBank brn_bank = gridUtility2.GetSelectedItem<Model.BrankBank>();
            if (brn_bank == null) return;
            frmEditBranchBankUpdate obj = new frmEditBranchBankUpdate(brn_bank);
            obj.updateBranch = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridViewBank_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Model.Bank bank = gridUtility1.GetSelectedItem<Model.Bank>();
            IList<Model.BrankBank> lstBranch = new List<Model.BrankBank>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBranch = uow.BrankBankBaseRepository.GetAllBrankByBankID(bank.BankId.ToString());
                uow.Commit();
            }
            gridUtility2.BindingData(lstBranch);
        }

        private void gridViewBranchBank_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                DeleteBranch();
                e.Handled = true;
            }
        }

        private void DeleteBranch()
        {
            int i = gridViewBranchBank.GetSelectedRows()[0];
            Model.BrankBank branch = gridUtility2.GetSelectedItem<Model.BrankBank>();
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.BrankBankBaseRepository.Remove(branch);
                    uow.Commit();
                }
                gridViewBranchBank.DeleteRow(i);
            }
        }

        private void DeleteBank()
        {
            int i = gridViewBank.GetSelectedRows()[0];
            Model.Bank branch = gridUtility1.GetSelectedItem<Model.Bank>();
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.BankBaseRepository.Remove(branch);
                    uow.Commit();
                }
                gridViewBank.DeleteRow(i);
            }
        }

        private void gridViewBank_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DeleteBank();
                e.Handled = true;
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void Search(string txtSearch)
        {
            if (string.IsNullOrWhiteSpace(txtSearch)) return;
            IList<Model.BrankBank> lstBranch;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBranch = uow.BrankBankBaseRepository.Search(txtSearch);
                uow.Commit();
            }
            gridUtility2.BindingData( lstBranch);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Search(txtSearch.Text);
            }
        }

        private void btnCreateBranchBank_Click(object sender, EventArgs e)
        {
            frmCreateBranchBankUpdate obj = new frmCreateBranchBankUpdate(gridUtility1.GetSelectedItem<Model.Bank>());
            obj.AddnewBranch = InsertOrUpdate;
            obj.ShowDialog();
        }
    }
}
