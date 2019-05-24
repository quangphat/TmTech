using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateBankUpdate : ModernUI.Forms.MetroForm
    {
        public frmCreateBankUpdate()
        {
            InitializeComponent();
        }

        public delegate void delgAddnewBank(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null);
        public delgAddnewBank addnewBank;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            Model.Bank bank = new Model.Bank();
            CoverObjectUtility.GetAutoBindingData(this, bank);
            //bank.BankCode = txtCode.Text;
            //bank.BankName = txtName.Text;
            //bank.Address = txtAddress.Text;
            //bank.Phone = txtPhone.Text;
            //bank.Fax = txtFax.Text;
            //bank.Email = txtEmail.Text;
            //bank.Note = txtNote.Text;
            bank.SetCreate();
            if (bank == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.BankBaseRepository.Add(bank);
                    uow.Commit();
                }
                labelNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                if (addnewBank != null)
                    addnewBank(bank, CRUD.Insert);
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

        private void frmCreateBankUpdate_Load(object sender, EventArgs e)
        {
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
        }
    }
}
