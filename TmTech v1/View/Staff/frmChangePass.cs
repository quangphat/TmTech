using ModernUI.Forms;
using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmChangePass : MetroForm
    {
        Users m_User;
        public frmChangePass(Users user)
        {
            InitializeComponent();
            m_User = user;
            lblNotify.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldpass = UtilityFunction.GetSHA256Hash(txtOldPass.Text.Trim());
            if(oldpass!= m_User.Password)
            {
                lblNotify.SetText(UI.passwordnotsame, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if(txtNewPass.Text.Length<8)
            {
                lblNotify.SetText(UI.passwordtooshort, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            string hashedpass = UtilityFunction.GetSHA256Hash(txtNewPass.Text.Trim());
            m_User.Password = hashedpass;
            m_User.ModifyBy = UserManagement.UserSession.UserName;
            m_User.ModifyDate = DateTime.Now;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UsersRepository.Update(m_User);
                    uow.Commit();
                }
                Close();
            }
            catch
            {
                lblNotify.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
