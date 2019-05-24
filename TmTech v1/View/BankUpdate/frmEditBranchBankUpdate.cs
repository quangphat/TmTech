using System;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditBranchBankUpdate : ModernUI.Forms.MetroForm
    {
        private BrankBank branch;
        public frmEditBranchBankUpdate(BrankBank branch)
        {
            InitializeComponent();
            this.branch = branch;
        }

        private void frmEditBranchBankUpdate_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            if(branch!=null)
            {
                if (branch.Bank == null)
                {
                    return;
                }
                CoverObjectUtility.SetAutoBindingData(this, branch);
            }
        }

        public delegate void delgUpdateBranch(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null);
        public delgUpdateBranch updateBranch;
        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, branch);
            branch.SetModify();
            
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.BrankBankBaseRepository.Update(branch);
                uow.Commit();
            }
            if (updateBranch != null)
                updateBranch(branch.Bank, CRUD.Update,branch);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
