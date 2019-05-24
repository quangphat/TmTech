using ModernUI.Forms;
using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmSetPassword : MetroForm
    {
        Users m_User;
        public frmSetPassword(Users user)
        {
            InitializeComponent();
            lblNotify.Text = "";
            this.m_User = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_User == null) return;
            if(m_User.UserId <=0) return;
            if (ValidationUtility.FieldNotAllowNull(this) == false)
            {
                lblNotify.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (ValidationUtility.ContainsUnicodeCharacter(txtPass.Text) == true)
            {
                lblNotify.SetText(UI.passwordnotallowspace, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (txtPass.Text != txtRePass.Text)
            {
                lblNotify.SetText(UI.passwordnotsame, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (txtPass.TextLength < 8)
            {
                lblNotify.SetText(UI.passwordtooshort, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_User.Password = UtilityFunction.GetSHA256Hash(txtPass.Text);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UsersRepository.Update(m_User);
                    uow.Commit();
                }
                lblNotify.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
