using ModernUI.Forms;
using TmTech.Resource;
using TmTech_v1.Bussiness;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Customer
{
    public partial class frmEditCompanyUpdate : MetroForm
    {
        CompanyRequestForm _companyRequestForm;
        CompanyBussiness companyBussiness;
        public frmEditCompanyUpdate(CompanyRequestForm companyRequestForm)
        {
            InitializeComponent();
            _companyRequestForm = companyRequestForm;
            companyBussiness = new CompanyBussiness();
        }
        private void Init()
        {
            if (!_companyRequestForm.isEdit)
            {
                lblTitle.Text = UI.CompanyTitleCreateNew;
                CreateNew();
                
            }
            else
            {
                lblTitle.Text = UI.CompanyTitleUpdate;
                Edit();
            }
            ReadData(_companyRequestForm.objectRequest);

        }
        private void CreateNew()
        {
            _companyRequestForm.objectRequest = new Company();
            FormUtility.ResetForm(this);
        }
        private void Edit()
        {

        }

        private void frmEditCompanyUpdate_Load(object sender, System.EventArgs e)
        {

        }
        private void ReadData( Company company)
        {
            txtCompanyCode.Text = company.CompanyCode;
            txtCompanyName.Text = company.CompanyName;
            cboTypeOfCompany.SelectedValue = company.TypeId;
            txtAddress.Text = company.Address;
            txtAccountant.Text = company.Accountant;
            txtPhoneAccountant.Text = company.AccountantPhone;
            txtSwich.Text = company.SwiftCode;
            txtTaxCode.Text = company.Taxcode;
            txtNoBrach.Text = company.Branch.ToString();
            txtStaft.Text = company.NumberOfEmployee.IntToString();
            txtNote.Text = company.Note;
            txtAcountBank.Text = company.BankName;
            txtNumberBank.Text = company.BankAccount;
            PictureUtility.BindImage(PictureSgnature, company.Photo);
            PictureUtility.BindImage(PictureLogo, company.PictureLogo);
            if (company.MainDeputy != null)
            {
                txtNameContact.Text = company.MainDeputy.DeputyName;
                txtPhone.Text = company.MainDeputy.Phone;
                txtEmail.Text = company.MainDeputy.Email;
                cbSex.SelectedValue = company.MainDeputy.Sex;
            }
            if (company.Class != null)
            {
                cbClassCustormer.SelectedValue = company.Class.CompanyClassId;
            }
        }

        private void AssignData(Company company)
        {
            company.CompanyCode = txtCompanyCode.Text;
            company.CompanyName = txtCompanyName.Text;
            company.TypeId = (int)cboTypeOfCompany.SelectedValue;
            company.Address = txtAddress.Text;
            company.Accountant = txtAccountant.Text;
            company.AccountantPhone = txtPhoneAccountant.Text;
            company.SwiftCode = txtSwich.Text;
            company.Taxcode = txtTaxCode.Text;
            company.Branch = txtNoBrach.Text.ConvertToInt();
            company.NumberOfEmployee = txtStaft.Text.ConvertToInt();
            company.Note = txtNote.Text;
            var itemBank = cbSelectBank.SelectedItem as Bank;
            if (PictureLogo.Tag != null)
            {
                company.PictureLogo = PictureUtility.SaveImg(PictureLogo.Tag.ToString());
            }
            if (PictureSgnature.Tag != null)
            {
                company.Photo = PictureUtility.SaveImg(PictureSgnature.Tag.ToString());
            }
            if (company.MainDeputy != null)
            {
                company.MainDeputy.DeputyName = txtNameContact.Text;
                company.MainDeputy.Phone = txtPhone.Text;
                company.MainDeputy.Email = txtEmail.Text;
                company.MainDeputy.Sex = cbSex.SelectedIndex > 0;
            }
            if (company.Class != null)
            {
                var companyClass = cbClassCustormer.SelectedValue as CompanyClass;
                company.ClassId = companyClass.CompanyClassId;
                company.Class = company.Class;
            }
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            AssignData(_companyRequestForm.objectRequest);
            int result = -1; 
            if(_companyRequestForm.isEdit)
            {
                result = companyBussiness.Insert(_companyRequestForm.objectRequest);
            }
            else
            {
                result = companyBussiness.Update(_companyRequestForm.objectRequest);
            }
            if( result>0)
            {
                labelNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                CompanyReponseView compReponseView = new CompanyReponseView();
                compReponseView.respose = _companyRequestForm.objectRequest;
                //_companyRequestForm.HandleSuccessData(compReponseView);
            }
            else
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Success);
            }
        }

        private void btnClearAll_Click(object sender, System.EventArgs e)
        {
            FormUtility.ResetForm(this);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
