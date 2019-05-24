using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmCreateStaff : MetroForm
    {
        public frmCreateStaff()
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
        }
        private void frmCreateStaff_Load(object sender, EventArgs e)
        {
            IList<Department> lstDepartment;
            IList<UserGroup> lstUserGroup;
            IList<StaffPosition> lstStaffPosition;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDepartment = uow.DepartmentRepository.All();
                lstUserGroup = uow.UserGroupRepository.All();
                lstStaffPosition = uow.StaffPositionRepository.All();
                uow.Commit();
            }
            ComboboxUtility.BindData(cbbDepartment, lstDepartment, "DepartmentName", "DepartmentId");
            cbbDepartment.SelectedValue = -1;
            ComboboxUtility.BindData(cbbUserGroup, lstUserGroup, "UserGroupName", "UserGroupId");
            cbbUserGroup.SelectedValue = -1;
            ComboboxUtility.BindData(cbbPosition, lstStaffPosition, "StaffPositionName", "StaffPositionId");
            cbbPosition.SelectedValue = -1;
        }

        public delegate void delgAddnewStaff(Staff staff);
        public delgAddnewStaff AddnewStaff;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;

            }
            if (txtPassword.Text.Trim() != txtRetype.Text.Trim())
            {
                lblNotify1.SetText(UI.passwordnotsame, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (txtPassword.Text.Length < 5)
            {
                lblNotify1.SetText(UI.passwordtooshort, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (cbbUserGroup.SelectedValue == null || cbbDepartment.SelectedValue == null)
            {
                lblNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (!rbtnFemale.Checked && !rbtnMale.Checked)
                return;
            //Create User
            Users user = new Users();
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.FullName = txtFullName.Text;
            user.Phone = txtPhone.Text;
            user.Email = txtEmail.Text;
            user.Address = txtAddress.Text;
            user.Sex = (rbtnFemale.Checked) ? false : true;
            user.UserGroupId = Convert.ToInt32(cbbUserGroup.SelectedValue);
            user.SetCreate();
            //modify date and modify by is null
            //add user
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UsersRepository.Add(user);
                    uow.Commit();
                }
            } catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            //Create Staff
            Staff staff = new Staff(user);
            staff.StaffCode = txtCode.Text;
            staff.StaffName = txtFullName.Text;
            //staff.Phone = txtPhone.Text;
            //staff.Email = txtEmail.Text;
            staff.Fax = txtFax.Text;
            staff.Skype = txtSkype.Text;
            staff.Birthday = dtpBirthday.DateTime;
            staff.BeginDate = dtpBeginDate.DateTime;
            staff.DepartmentId = Convert.ToInt32(cbbDepartment.SelectedValue);
            staff.PositionId = Convert.ToInt32(cbbPosition.SelectedValue);
            staff.Avatar = ptAvatar.Image != null ? PictureUtility.getFileName(ptAvatar.Tag.ToString()) : "";
            staff.SignaturePhoto = ptSignature.Image != null ? PictureUtility.getFileName(ptSignature.Tag.ToString()): "";
            staff.SetCreate();
            //modify date and modify by is null    
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    staff.UserId = uow.UsersRepository.Find(user.UserName);
                    uow.StaffRepository.Add(staff);
                    uow.Commit();
                }
            } catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (AddnewStaff != null)
                AddnewStaff(staff);
            Close();
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowseavatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptAvatar);
        }

        private void btnBrowseSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptSignature);
        }
    }
}
