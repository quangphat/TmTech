
using System;
using System.Data;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmEditUser : MetroForm
    {
        Users m_CustomUser;
        IDbConnection db = DbTmTech.DbCon;
        public frmEditUser()
        {
            InitializeComponent();
            m_CustomUser = new Users();
        }
        public frmEditUser(Users customeUser)
        {
            InitializeComponent();
            m_CustomUser = customeUser;
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            if(m_CustomUser != null)
            {
                using(IUnitOfWork uow = new UnitOfWork())
                {
                    m_CustomUser = uow.UsersRepository.Find(m_CustomUser.UserId);
                    uow.Commit();
                }
                if(m_CustomUser!=null)
                {
                    string select = string.Empty;
                    txtUserName.Text = m_CustomUser.UserName;
                    txtRecoverEmail.Text = m_CustomUser.Email;
                    txtUser.Text = m_CustomUser.FullName;
                }
                
            }
        }

        public delegate void delgSetFormEnable(bool isEnable);
        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrimary frmPrimary = FormUtility.FindForm("frmPrimary") as frmPrimary;
            if (frmPrimary == null) return;
            delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
            delg(true);
        }
        private void Edit(int Id,Users user)
        {
            //if(Id!=0 && user!=null)
            //{
            //    Users account = Database.Find<Users>("select * from Users where Id = " + Id.ToString());
            //    if(account!=null)
            //    {
            //        using(IUnitOfWork uow = new UnitOfWork())
            //        {
            //            uow.UsersRepository.Update(user);
            //            uow.Commit();
            //        }
            //    }
            //}
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //Users customUser = new Users();
            //if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtOldPass.Text)  || string.IsNullOrWhiteSpace(txtRetypePass.Text) || string.IsNullOrWhiteSpace(txtRecoverEmail.Text))
            //{
            //    FlatMessageBox.FlatMsgBox.Show("Bạn phải nhập đủ thông tin", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
            //    return;
            //}
            //Users account = Database.Find<Users>("select * from Users where UserName = '" + txtUserName.Text.Trim() + "'");
            //if (account == null)
            //{
            //    FlatMessageBox.FlatMsgBox.Show("Tên đăng nhập không đúng", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
            //    return;
            //}
            //if (UtilityFunction.GetSHA256Hash(txtOldPass.Text) != account.Password)
            //{
            //    FlatMessageBox.FlatMsgBox.Show("Mật khẩu không đúng", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
            //    return;
            //}
            //if (txtNewPass.Text.Trim() != txtRetypePass.Text.Trim())
            //{
            //    FlatMessageBox.FlatMsgBox.Show("Mật khẩu mới không khớp", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
            //    return;
            //}
            //customUser.UserId = m_CustomUser.UserId;
            //customUser.UserName = txtUserName.Text;
            //customUser.Password = UtilityFunction.GetSHA256Hash(txtNewPass.Text);
            //customUser.Email = txtRecoverEmail.Text;
            //customUser.ModifyBy = UserManagement.UserSession.UserName;
            //customUser.ModifyDate = DateTime.Today;
            //Edit(customUser.UserId, customUser);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
