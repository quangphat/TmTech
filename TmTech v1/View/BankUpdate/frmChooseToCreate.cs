using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmChooseToCreate : ModernUI.Forms.MetroForm
    {
        public frmChooseToCreate()
        {
            InitializeComponent();
        }

        private void frmChooseToCreate_Load(object sender, System.EventArgs e)
        {
            //Load for combobox
            AcceptButton = btnSave;
            IList<Bank> lstBank = new List<Bank>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBank = uow.BankBaseRepository.All();
                uow.Commit();
            }
            ComboboxUtility.BindData<Bank>(cbbBank, lstBank, "BankName", "BankId");
        }

        public delegate void delgInsert(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null);
        public delgInsert insert;

        private void Insert(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null)
        {
            if (insert != null)
                insert(bank, cru, branch);
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (rbtnBank.Checked)
            {
                frmCreateBankUpdate obj1 = new frmCreateBankUpdate();
                obj1.addnewBank = Insert;
                obj1.ShowDialog();
                Close();
            }
            if (rbtnBranch.Checked)
            {
                Model.Bank bank;
                bank = cbbBank.SelectedItem as Model.Bank;
                //using (Interface.IUnitOfWork uow = new Repository.UnitOfWork())
                //{
                //    bank = uow.BankRepository.Find(Convert.ToInt32(cbbBank.SelectedValue));
                //    uow.Commit();
                //}
                if (bank == null) return;
                frmCreateBranchBankUpdate obj2 = new frmCreateBranchBankUpdate(bank);
                obj2.AddnewBranch = Insert;
                obj2.ShowDialog();
                Close();
            }
        }

        private void controlVisible(bool b)
        {
            label1.Visible = b;
            cbbBank.Visible = b;

        }
        private void rbtnBank_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbtnBank.Checked)
            {
                controlVisible(false);
            }
            else
                controlVisible(true);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
