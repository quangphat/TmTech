using System;
using ModernUI.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;


namespace TmTech_v1.View
{

    public partial class frmCreateDeputy : MetroForm
    {


        private readonly int _companyID = -1;
        public delegate void XulyThemMoiDeputy(Deputy deputy);
        public XulyThemMoiDeputy _xulyThemMoiDeputy;

        public frmCreateDeputy(int companyID)
        {
            InitializeComponent();
            _companyID = companyID;
        }

        private void frmCreateProduct_Load(object sender, EventArgs e)
        {
            FormUtility.ResetForm(this);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormUtility.ShowParentForm();
            Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;

            Deputy deputy = new Deputy
            {
                Skype = txtSkype.Text,
                Address = txtDiaChi.Text,
                Email = txtEmail.Text,
                DeputyName = txtNameContact.Text,
                Phone = txtPhone.Text,
                CompanyId = _companyID,
                IsActive = true,
                IsMain = false,
                Sex = (cbSex.SelectedIndex) < 1 ? false : true,
                CreateBy = UserManagement.UserSession.UserName,
                CreateDate = DateTime.Now
            };


            Users userNew = new Users
            {
                UserName = txtAccount.Text,
                Password = UtilityFunction.GetSHA256Hash(txtPassword.Text),
                Email = txtEmail.Text,
                FullName = txtNameContact.Text,
                CreateBy = deputy.CreateBy,
                CreateDate = deputy.CreateDate,
                UserGroupId = 2

            };


            Users userCheck = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {

                userCheck = uow.UsersRepository.IsExist(userNew.UserName);
            }
            if (userCheck != null)
            {

                UtilityMessageBox.ShowText("UserName is exit, not valid");
                return;
            }


            using (IUnitOfWork uow = new UnitOfWork())
            {
                //int k = uow.UsersRepository.Add(userNew);
                //deputy.UserId = k;
                //uow.DeputyRepository.Add(deputy);


                uow.Commit();
            }

            UtilityMessageBox.ShowText("Thêm mới thành công");

            if (_xulyThemMoiDeputy != null)
            {
                _xulyThemMoiDeputy(deputy);
            }
            Close();

        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {

            FormUtility.ResetForm(this);
        }

    }
}
