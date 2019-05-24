using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

// ReSharper disable CheckNamespace
namespace TmTech_v1.View
// ReSharper restore CheckNamespace
{
    public partial class FrmEditCompany : MetroForm
    {
        private Company _objEditCompany = null;

        public FrmEditCompany(int companyId)
        {

            InitializeComponent();

            _objEditCompany = new Company
            {
                CompanyId = companyId
            };

            ComboboxUtility.LoadDataClassCustormer(cbClassCustormer);
            cbClassCustormer.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public delegate void XulyCapNhat(Company compnay, Deputy deputymain);
        public XulyCapNhat XulysaukhiCapNhat;
        private Deputy _objMain = new Deputy();
        private void btnCancel_Click(object sender, EventArgs e)
        {

            Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            if (_objEditCompany == null)
                return;
            _objEditCompany.CompanyName = txtCompanyName.Text;
            _objEditCompany.CompanyCode = txtCompanyCode.Text;
            _objEditCompany.Taxcode = txtTaxCode.Text;
            _objEditCompany.Address = txtAddree.Text;
            _objEditCompany.SwiftCode = txtSwich.Text;
            _objEditCompany.NumberOfEmployee = ValidationUtility.StringIsNull(txtStaft.Text) == false ? int.Parse(txtStaft.Text) : 0;
            _objEditCompany.Branch = ValidationUtility.StringIsNull(txtNoBrach.Text) == false ? int.Parse(txtNoBrach.Text) : 0;
            _objEditCompany.TagetValue = ValidationUtility.StringIsNull(txtTargertValue.Text) == false ? int.Parse(txtTargertValue.Text) : 0;
            _objEditCompany.Website = txtWebsite.Text;
            _objEditCompany.CreateDate = DateTime.Now;
            _objEditCompany.CreateBy = UserManagement.UserSession.UserName;
            _objEditCompany.Note = txtNote.Text;
            _objEditCompany.isActive = true;
            _objEditCompany.Accountant = txtAccount.Text;
            _objEditCompany.AccountantPhone = txtAccount.Text;
            var companyClass = cbClassCustormer.SelectedItem as CompanyClass;
            if (companyClass != null)
                _objEditCompany.ClassId = cbClassCustormer.SelectedValue != null ? companyClass.CompanyClassId : 0;


            if (PictureLogo.Tag != null)
            {
                _objEditCompany.PictureLogo = PictureUtility.SaveImg(PictureLogo.Tag.ToString());
            }
            if (PictureSgnature.Tag != null)
            {
                _objEditCompany.Photo = PictureUtility.SaveImg(PictureSgnature.Tag.ToString());
            }

            _objMain.DeputyName = txtNameContact.Text;
            _objMain.Address = txtAddree.Text;
            _objMain.Phone = txtPhone.Text;
            _objMain.IsMain = true;
            _objMain.IsActive = true;
            _objMain.Sex = (cbSex.SelectedIndex) < 0;
            _objMain.Email = txtEmail.Text;
            _objMain.ModifyBy = UserManagement.UserSession.UserName;
            _objMain.ModifyDate = DateTime.Now;


            if (userEdit != null)
            {
                userEdit.UserName = txtAccount.Text;
                userEdit.FullName = txtNameContact.Text;
                userEdit.ModifyBy = UserManagement.UserSession.UserName;
                userEdit.ModifyDate = DateTime.Now;
            }

            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.CompanyRepository.Update(_objEditCompany);
                uow.DeputyRepository.Update(_objMain);
                uow.UsersRepository.Update(userEdit);
                uow.Commit();
            }
            if (XulysaukhiCapNhat != null)
            {
                XulysaukhiCapNhat(_objEditCompany, _objMain);
                Close();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            FormUtility.ResetForm(this);

        }


        Users userEdit = null;

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                _objEditCompany = uow.CompanyRepository.Find(_objEditCompany.CompanyId);
                uow.Commit();
            }
            cbSex.SelectedIndex = 0;

            txtCompanyCode.Text = _objEditCompany.CompanyCode;
            txtCompanyName.Text = _objEditCompany.CompanyName;
            txtTaxCode.Text = _objEditCompany.Taxcode;
            txtAddree.Text = _objEditCompany.Address;
            txtSwich.Text = _objEditCompany.SwiftCode;
            txtNoBrach.Text = (_objEditCompany.Branch != 0) ? _objEditCompany.Branch.ToString() : string.Empty;
            txtStaft.Text = (_objEditCompany.NumberOfEmployee != null) ? _objEditCompany.Branch.ToString() : string.Empty;
            txtWebsite.Text = _objEditCompany.Website;
            txtNote.Text = _objEditCompany.Note;
            txtTargertValue.Text = (_objEditCompany.TagetValue != 0) ? _objEditCompany.TagetValue.ToString() : string.Empty;
            cbClassCustormer.SelectedValue = _objEditCompany.ClassId;
            PictureUtility.BindImage(PictureSgnature, _objEditCompany.Photo);
            PictureUtility.BindImage(PictureLogo, _objEditCompany.PictureLogo);
            txtAccount.Text = _objEditCompany.Accountant;
            txtAccount.Text = _objEditCompany.AccountantPhone;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                _objMain = uow.DeputyRepository.FindMainDeputy(_objEditCompany.CompanyId);
            }
            Users user = UtilityFunction.GetUser(_objMain);
            string account = user != null ? user.UserName : "";
            using (IUnitOfWork uow = new UnitOfWork())
            {
                userEdit = uow.UsersRepository.IsExist(account);

            }
            if (_objMain == null)
            {
                return;
            }
            txtNameContact.Text = _objMain.DeputyName;
            txtEmail.Text = _objMain.Email;
            txtPhone.Text = _objMain.Phone;
            cbSex.SelectedIndex = _objMain.Sex ? 0 : 1;
            if (userEdit == null)
                return;
            txtAccount.Text = userEdit.UserName;
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(PictureSgnature);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(PictureLogo);
        }
        private void cboTypeOfCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTaxCode.ReadOnly = (cboTypeOfCompany.SelectedIndex > 0);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmchangePass = new frmChangePass(userEdit);
            frmchangePass.ShowDialog();
        }
    }
}
