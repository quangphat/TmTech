using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;


namespace TmTech_v1.View
{
    public partial class frmEditBankUpdate : ModernUI.Forms.MetroForm
    {
        private Model.Bank m_bank;

        public frmEditBankUpdate(Model.Bank bank)
        {
            InitializeComponent();
            m_bank = bank;
        }

        private void frmEditBankUpdate_Load(object sender, EventArgs e)
        {
            if(m_bank!=null)
            {
                labelNotify1.Text = "";
                CoverObjectUtility.SetAutoBindingData(this, m_bank);
                txtBankCode.Select();
                //txtBankCode.Text = m_bank.BankCode;
                //txtBankName.Text = m_bank.BankName;
                //txtBankAddress.Text = m_bank.Address;
                //txtBankPhone.Text = m_bank.Phone;
                //txtBankFax.Text = m_bank.Fax;
                //txtBankEmail.Text = m_bank.Email;
                //txtBankNote.Text = m_bank.Note;
                //txtCreatedDate.Text = m_bank.CreateDate != null ? UtilityFunction.DateTimeToString((DateTime)m_bank.CreateDate) : "";
                //txtCreatedBy.Text = m_bank.CreateBy;
            }
        }

        public delegate void delgUpdateBank(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null);
        public delgUpdateBank updateBank;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //m_bank.BankCode = txtBankCode.Text;
            //m_bank.BankName = txtBankName.Text;
            //m_bank.Address = txtBankAddress.Text;
            //m_bank.Phone = txtBankPhone.Text;
            //m_bank.Fax = txtBankFax.Text;
            //m_bank.Email = txtBankEmail.Text;
            //m_bank.Note = txtBankNote.Text;
            CoverObjectUtility.GetAutoBindingData(this, m_bank);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.BankBaseRepository.Update(m_bank);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (updateBank != null)
                updateBank(m_bank, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
