using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateBranchBankUpdate : ModernUI.Forms.MetroForm
    {
        private Model.Bank bank;
        public frmCreateBranchBankUpdate(Model.Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void frmCreateBranchBankUpdate_Load(object sender, EventArgs e)
        {
            if (bank == null)
                return;
            //txtBank.Text = bank.BankName;
            CoverObjectUtility.SetAutoBindingData(this, bank);
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
        }

        public delegate void delgAddnewBranch(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null);
        public delgAddnewBranch AddnewBranch;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            Model.BrankBank branch = new BrankBank();
            CoverObjectUtility.GetAutoBindingData(this, branch);
            branch.BankId = bank.BankId;
            branch.SetCreate();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.BrankBankBaseRepository.Add(branch);
                    uow.Commit();
                }
                labelNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                if (AddnewBranch != null)
                    AddnewBranch(bank, CRUD.Insert, branch);
                Close();
            }
            catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
