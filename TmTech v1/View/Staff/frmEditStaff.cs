using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditStaff : MetroForm
    {
        Staff m_Staff;
        public frmEditStaff(Staff staff)
        {
            InitializeComponent();
            m_Staff = staff;
            lblNotify1.Text = "";
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
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
            ComboboxUtility.BindData(cbbUserGroup, lstUserGroup, "UserGroupName", "UserGroupId");
            ComboboxUtility.BindData(cbbPosition, lstStaffPosition, "StaffPositionName", "StaffPositionId");
            InitializeForm(m_Staff);
        }
        private void InitializeForm(Staff staff)
        {
            //txtFullName.Text = staff.StaffName;
            //txtEmail.Text = staff.Email;
            //txtCode.Text = staff.StaffCode;
            //txtUserName.Text = staff.User!=null?staff.User.UserName:string.Empty;
            //txtPhone.Text = staff.Phone;
            //dtpBirthday.DateTime = staff.Birthday != null ? staff.Birthday.Value : DateTime.Today;
            //dtpBeginDate.DateTime = staff.BeginDate!=null? staff.BeginDate.Value:DateTime.Today;
            //txtAddress.Text = staff.Address;
            //cbbDepartment.SelectedValue = m_Staff.DepartmentId;
            //cbbUserGroup.SelectedValue = staff.UserGroup != null ? staff.UserGroup.UserGroupId : 0;
            //cbbPosition.SelectedValue = m_Staff.StaffPosition != null ? staff.StaffPosition.StaffPositionId : 0;
            CoverObjectUtility.SetAutoBindingData(this, staff);
            if (staff.Sex)
                rbtnMale.Checked = true;
            else
                rbtnFemale.Checked = true;
            if (!ValidationUtility.StringIsNull(staff.Avatar))
                PictureUtility.BindImage(ptAvatar, staff.Avatar);
            if (!ValidationUtility.StringIsNull(staff.SignaturePhoto))
                PictureUtility.BindImage(ptSignature, staff.SignaturePhoto);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidationUtility.FieldNotAllowNull(this)==false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            //m_Staff.StaffName = txtFullName.Text;
            //m_Staff.Email = txtEmail.Text;
            //m_Staff.StaffCode = txtCode.Text;
            //m_Staff.Phone = txtPhone.Text;
            //m_Staff.Birthday = dtpBirthday.DateTime;
            //m_Staff.BeginDate = dtpBeginDate.DateTime;
            //m_Staff.Address = txtAddress.Text;
            if(ptAvatar.Tag!=null)
                m_Staff.Avatar = PictureUtility.SaveImg(ptAvatar.Tag.ToString());
            if(ptSignature.Tag!=null)
                m_Staff.SignaturePhoto  = PictureUtility.SaveImg(ptSignature.Tag.ToString());
            //m_Staff.DepartmentId = Convert.ToInt32(cbbDepartment.SelectedValue);
            //m_Staff.ModifyBy = UserManagement.UserSession.UserName;
            //m_Staff.ModifyDate = DateTime.Now;
            //m_Staff.PositionId = Convert.ToInt32(cbbPosition.SelectedValue);
            CoverObjectUtility.GetAutoBindingData(this, m_Staff);
            m_Staff.Sex = (rbtnFemale.Checked) ? false : true;
            m_Staff.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    IList<Users> lstUser = uow.UsersRepository.All();
                    if (lstUser == null) lstUser = new List<Users>();
                    Users exist = lstUser.Where(p => p.UserName == m_Staff.User.UserName && p.UserId != m_Staff.User.UserId).FirstOrDefault();
                    if (exist != null)
                    {
                        lblNotify1.SetText(UI.userhasexist, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                        uow.Commit();
                        return;
                    }
                    uow.StaffRepository.Update(m_Staff);
                    if (m_Staff.User != null)
                    {
                        uow.UsersRepository.Update(m_Staff.User);
                    }
                    uow.Commit();
                }
                Close();
            }
            catch
            {
                lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            //}
            //catch 
            //{
            //    MessageBox.Show(ex.Message);
            //    lblNotify1.SetText(MesgBox.updatefailed, ToolBoxCS.LabelNotify.enumStatus.failed);
            //}
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkChangeSignaturePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptAvatar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptSignature);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(m_Staff.User==null) return;
            frmChangePass frmChangePass = new frmChangePass(m_Staff.User);
            frmChangePass.ShowDialog();

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
