
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmCreateUser : MetroForm
    {
        IDbConnection db = DbTmTech.DbCon;
        
        
        private enum UserTypes {Company =1, Nhanvien  =2};
        public frmCreateUser()
        {
            InitializeComponent();

        }

        private void Create_Load(object sender, EventArgs e)
        {
            List<UserType> lstUserType;
            List<Company> lstCompany;
            List<UserGroup> lstUserGroup;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCompany = uow.CompanyRepository.All();
                lstUserType = uow.UserTypeRepository.All();
                lstUserGroup = uow.UserGroupRepository.All();
                uow.Commit();
            }
            if (lstUserGroup != null)
                ComboboxUtility.BindData<UserGroup>(cbbUserGroup, lstUserGroup, "GroupName", "Id");
            cbbUserGroup.SelectedValue = -1;
            if (lstUserType != null)
                ComboboxUtility.BindData<UserType>(cbbUsertype, lstUserType, "Name", "Id");
        }

        public delegate void delgSetFormEnable(bool isEnable);
        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrimary frmPrimary = FormUtility.FindForm("frmPrimary") as frmPrimary;
            if (frmPrimary == null) return;
            delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
            delg(true);
        }
        


        private bool Create(Users user)
        {
            if (user == null) return false;;
            try
            {
                using(IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UsersRepository.Add(user);
                    uow.Commit();
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        //private void LoadUserStaff()
        //{
        //    BindingSource bds = new BindingSource();
        //    if (cbbUsertype.SelectedValue.ToString() == ((int)UserTypes.Company).ToString())
        //    {
        //        bds.DataSource = lstCompany;
        //        cbbUser.DataSource = bds.DataSource;
        //        cbbUser.DisplayMember = "Name";
        //        cbbUser.ValueMember = "Id";
        //    }
        //    if (cbbUsertype.SelectedValue.ToString() == ((int)UserTypes.Nhanvien).ToString())
        //    {
        //       // cbbUser.DataSource = lstStaff;
        //        cbbUser.DisplayMember = "Name";
        //        cbbUser.ValueMember = "Id";
        //    }
        //}


        private void lnkCreateUserGroup_Click(object sender, EventArgs e)
        {
            frmPrimary frmPrimary = FormUtility.FindForm("frmPrimary") as frmPrimary;
            if (frmPrimary == null) return;
            TabPage tabUserGroup = new TabPage("User Group");
            tabUserGroup.Name = "UserGroup";
            Close();
        }
        private delegate void delgRefresh();
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtRetypePass.Text) || string.IsNullOrWhiteSpace(txtRecoverEmail.Text))
            {
                FlatMessageBox.FlatMsgBox.Show("Bạn phải nhập đủ thông tin", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            if (txtPass.Text.Trim() != txtRetypePass.Text.Trim())
            {
                FlatMessageBox.FlatMsgBox.Show("Mật khẩu không khớp", "", FlatMessageBox.FlatMsgBox.Buttons.OK, FlatMessageBox.FlatMsgBox.Icon.Info);
                return;
            }
            Users user = new Users();
            user.UserName = txtUserName.Text;
            user.Password = UtilityFunction.GetSHA256Hash(txtPass.Text);
            user.Email = txtRecoverEmail.Text;
            user.ModifyDate = DateTime.Now;
            user.ModifyBy = UserManagement.UserSession.UserName;
            user.FullName = txtFullName.Text;
            user.CreateDate = DateTime.Now;
            user.CreateBy = user.ModifyBy;
            if (cbbUserGroup.SelectedValue != null)
                user.UserGroupId = int.Parse(cbbUserGroup.SelectedValue.ToString());
            if (Create(user) == true)
            {
                FlatMessageBox.FlatMsgBox.Show("Success");
                frmUsersView frmViewUser = FormUtility.FindUserCtrl("frmUsersView") as frmUsersView;
                if (frmViewUser != null)
                {
                    if (UserManagement.AllowViewAll("USers") == true)
                        frmViewUser.isLoadAll = true;
                    else
                        frmViewUser.isLoadAll = false;
                    delgRefresh delgLoadUser = new delgRefresh(frmViewUser.LoadGrid);
                    delgLoadUser();
                    Close();
                }
            }
            else
            {
                FlatMessageBox.FlatMsgBox.Show("Không thành công");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbUsertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbbUsertype.SelectedValue.ToString()=="1")
            {
                cbbUserGroup.SelectedValue = 2;
                cbbUserGroup.Enabled = false;
            }
            else
            {
                cbbUserGroup.Enabled = true;
            }
        }
    }
}
