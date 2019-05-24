using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditDeputy : MetroForm
    {
        private Boolean disableMain = false;


        private Deputy objEdit = null;

        Users userEdit = null;
        public XuLySauKhiDisaBle _XuLySauKhiDisaBle;
        public XuLySauKhiUpdate _XuLySauKhiUpdate;

        public frmEditDeputy(Deputy _objEdit)
        {
            InitializeComponent();
            objEdit = _objEdit;
        }

        public delegate void XuLySauKhiDisaBle(Deputy deputy);
        public delegate void XuLySauKhiUpdate(Deputy deputy);


        private void bootstrapButton1_Click(object sender, EventArgs e)
        {
            if (objEdit.CompanyId<0)
            {
                return;
            }

            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.DeputyRepository.Remove(objEdit.DeputyId);
                uow.Commit();
                FlatMessageBox.FlatMsgBox.Show("Đã vô hiệu hóa thành công");
            }

            if (_XuLySauKhiDisaBle != null)
            {
                _XuLySauKhiDisaBle(objEdit);
                Close();
            }


        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            FormUtility.ResetForm(this);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            var deputy = objEdit;
            deputy.Skype = txtSkype.Text;
            deputy.Address = txtDiaChi.Text;
            deputy.Email = txtEmail.Text;
            deputy.DeputyName = txtNameContact.Text;
            deputy.Phone = txtPhone.Text;
            deputy.CompanyId = objEdit.CompanyId;
            deputy.IsActive = checkIsActive.Checked;
            deputy.ModifyBy = UserManagement.UserSession.UserName;
            deputy.ModifyDate = DateTime.Now;
            deputy.Note = txtNote.Text;
            deputy.Sex = (cbSex.SelectedIndex < 1);
            deputy.IsMain = cbMain.Checked;

            if (userEdit != null)
            {
                userEdit.UserName = txtAccount.Text;
                userEdit.FullName = txtNameContact.Text;
                userEdit.ModifyBy = UserManagement.UserSession.UserName;
                userEdit.ModifyDate = DateTime.Now;

            }
            using (IUnitOfWork uow = new UnitOfWork())
            {

                uow.DeputyRepository.Update(deputy);
                uow.UsersRepository.Update(userEdit);
                uow.Commit();
            }
            UtilityMessageBox.ShowText("cập nhật thành công");

            if (_XuLySauKhiUpdate != null)
                _XuLySauKhiUpdate(deputy);

            Close();

        }

        private void cbMain_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMain_Click(object sender, EventArgs e)
        {
            if (disableMain == true)
            {
                UtilityMessageBox.ShowText("không được disable tài khoản chính, vì chỉ còn một tài khoản chính");

            }

        }


        private void frmCreateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtility.ShowParentForm();
        }

        private void frmCreateProduct_Load(object sender, EventArgs e)
        {
            if (objEdit == null)
                return;
            txtNameContact.Text = objEdit.DeputyName;
            txtPhone.Text = objEdit.Phone;
            txtSkype.Text = objEdit.Skype;
            txtEmail.Text = objEdit.Email;
            txtNote.Text = objEdit.Note;
            checkIsActive.Checked = objEdit.IsActive;
            txtDiaChi.Text = objEdit.Address;
            cbSex.SelectedIndex = (objEdit.Sex) ? 0 : 1;
            cbMain.Checked = objEdit.IsMain;


            Users user = UtilityFunction.GetUser(objEdit);
            string account = user != null ? user.UserName : "";
            if (objEdit.IsMain == true)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    userEdit = uow.UsersRepository.IsExist(account);
                    Boolean ismainTemp = uow.DeputyRepository.CheckIsMain(objEdit.CompanyId);
                    if (ismainTemp == false)
                    {
                        disableMain = true;
                    }
                    else
                    {
                        disableMain = false;
                    }
                }
            }
            txtAccount.Text = userEdit.UserName;
           
            if (disableMain == true)
            {
                cbMain.AutoCheck = false;
            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmChangePass frmchangePass = new frmChangePass(userEdit);
            frmchangePass.ShowDialog();


        }
    }
}
