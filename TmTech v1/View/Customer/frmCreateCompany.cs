using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Bussiness;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateCompany : MetroForm
    {
        private readonly ICompanyBussiness _companyBussiness;
        public frmCreateCompany()
        {
            InitializeComponent();
            _companyBussiness = new CompanyBussiness();
            ComboboxUtility.BindBank(cbSelectBank);
            ComboboxUtility.LoadDataClassCustormer(cbClassCustormer);
            cbSelectBank.SelectedIndex = -1;
            txtAddree.Text = string.Empty;
            cbClassCustormer.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public delegate void XuLyThemMOi(Company compnay, Deputy deputymain);
        public XuLyThemMOi Xulysaukhithemmoi;
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            FormUtility.ResetForm(this);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cboTypeOfCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTypeOfCompany.SelectedIndex < 0)
                return;
            if (cboTypeOfCompany.SelectedIndex != 0)
            {
                txtTaxCode.Text = Constraint.TaxtCodePersonal;
                txtTaxCode.ReadOnly = true;
            }
            else
            {
                txtTaxCode.Text = string.Empty;
                txtTaxCode.ReadOnly = false;
            }
        }
        private void Click_OpenPictureLogo(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(PictureLogo);
        }
        private void Click_OpenPictureSgnature(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(PictureSgnature);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
            {
                return;
            }
            var company = new Company
            {
                CompanyName = txtCompanyName.Text,
                CompanyCode = txtCompanyCode.Text,
                Taxcode = txtTaxCode.Text,
                Address = txtAddree.Text,
                SwiftCode = txtSwich.Text,
                NumberOfEmployee = ValidationUtility.StringIsNull(txtStaft.Text) == false ? int.Parse(txtStaft.Text) : 0,
                Branch = ValidationUtility.StringIsNull(txtNoBrach.Text) == false ? int.Parse(txtNoBrach.Text) : 0,
                TagetValue =
                    ValidationUtility.StringIsNull(txtTargertValue.Text) == false ? int.Parse(txtTargertValue.Text) : 0,
                Website = txtWebsite.Text,
                CreateDate = DateTime.Now,
                CreateBy = UserManagement.UserSession.UserName,
                Note = txtNote.Text,
                isActive = true,
                Accountant =  txtAccount.Text,
                AccountantPhone =  txtPhoneAccountant.Text,
            };
            var companyClass = cbClassCustormer.SelectedItem as CompanyClass;
            if (companyClass != null)
                company.ClassId = cbClassCustormer.SelectedValue != null ? companyClass.CompanyClassId : 0;
            var accountBank = (cbSelectBank.SelectedValue != null) ? cbSelectBank.SelectedValue.ToString() : string.Empty;
            switch (cboTypeOfCompany.SelectedIndex)
            {
                case 1:
                    company.TypeId = 1;
                    break;
                default:
                    company.TypeId = 0;
                    break;
            }
            if (PictureLogo.Tag != null)
            {
                company.PictureLogo = PictureUtility.SaveImg(PictureLogo.Tag.ToString());
            }
            if (PictureSgnature.Tag != null)
            {
                company.Photo = PictureUtility.SaveImg(PictureSgnature.Tag.ToString());
            }
            var deputy = new Deputy
            {
                DeputyName = txtNameContact.Text,
                Address = txtAddree.Text,
                Phone = txtPhone.Text,
                IsMain = true,
                IsActive = true,
                Email = txtEmail.Text,
                Sex = (cbSex.SelectedIndex <= 0),
                CreateBy = UserManagement.UserSession.UserName,
                CreateDate = DateTime.Now
            };
            var userNew = new Users
            {
                UserName = txtAccount.Text,
                Password = UtilityFunction.GetSHA256Hash(txtPassword.Text),
                Email = txtEmail.Text,
                FullName = txtNameContact.Text,
                CreateBy = deputy.CreateBy,
                CreateDate = deputy.CreateDate,
                UserGroupId = 2
            };
            Users userCheck;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                userCheck = uow.UsersRepository.IsExist(userNew.UserName);
            }
            if (userCheck != null)
            {
                UtilityMessageBox.ShowText("UserName is exist, not valid");
                return;
            }
            if (PictureSgnature.Tag != null)
            {
                company.Photo = PictureUtility.SaveImg(PictureSgnature.Tag.ToString());
            }
            if (PictureLogo.Tag != null)
            {
                company.PictureLogo = PictureUtility.SaveImg(PictureLogo.Tag.ToString());
            }
            var companyId = _companyBussiness.Insert(company);
            company.CompanyId = companyId;
            deputy.CompanyId = companyId;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                //var useridnew = uow.UsersRepository.Add(userNew);
                //deputy.UserId = useridnew;
                //uow.DeputyRepository.Add(deputy);
                //uow.Commit();
            }
            if (Xulysaukhithemmoi == null) return;
            Xulysaukhithemmoi(company, deputy);
            Close();
        }
    }
}
