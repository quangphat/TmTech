using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using System.Data;
using FlatMessageBox;
using TmTech_v1.Interface;

namespace TmTech_v1
{
    public partial class frmLogin : MetroForm
    {
        IDbConnection db = null;
        public frmLogin()
        {
            this.Select();
            InitializeComponent();
            this.txtUserName.TabIndex = 10;
            txtUserName.Select();
            txtUserName.Focus();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUserName.Select();
            txtUserName.Focus();
            this.AcceptButton = btnLogin;
            txtUserName.Text = "quangphat";
            txtPass.Text = "number8";
        }
        private void btnSetupDb_Click(object sender, EventArgs e)
        {
            frmSetupDb frmSetupDb = new frmSetupDb();
            frmSetupDb.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DbTmTech.GetDbFromFile() == false)
            {
                FlatMsgBox.Show("Chưa thiết lập kết nối");
                return;
            }
            else
            {
                if (DbTmTech.TestConnect() == false)
                {
                    FlatMsgBox.Show("Chưa thiết lập kết nối");
                    return;
                }
                else
                    db = DbTmTech.DbCon;
            }
            string passHashed = UtilityFunction.GetSHA256Hash(txtPass.Text);
            Users user;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                user = uow.UsersRepository.Login(txtUserName.Text, passHashed);
                uow.Commit();
            }
            if (user == null)
            {
                FlatMessageBox.FlatMsgBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Login Failed", FlatMessageBox.FlatMsgBox.Buttons.OK);
                return;
            }
            UserManagement.SetUserSession(user);
            frmPrimary frmPrimay  =new frmPrimary();
            frmPrimay.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
