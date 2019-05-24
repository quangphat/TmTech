using System;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class InformationCustomer : UserControl
    {
        private Company _companySelect = null;
        private string _Account = string.Empty;
        public InformationCustomer(  string account )
        {
            InitializeComponent();

            _Account = account;
            FormUtility.ReadOnly(this);
        }

        private void BtnUpdateSubAccout_Click(object sender, EventArgs e)
        {
            DialogResult btnSeclect = UtilityMessageBox.WarningOpeartor(NotificationMessage.MsgIsupdateQuestion);
            if (btnSeclect == DialogResult.No)
                return;


            Deputy objDeputy = _companySelect.MainDeputy;
          
            if( objDeputy==null)
            {
                UtilityMessageBox.ShowText("không có thông tin cập nhật");
                return;
            }

               

            var objFrmDeputyEdit = new frmEditDeputy(objDeputy)
            {
                _XuLySauKhiUpdate = XuLySauKhiUpdate
                
            };

            objFrmDeputyEdit.ShowDialog();

        }

      
        void LoadDeputy(Deputy objLoad)
        {
            if (objLoad == null)
                return;

            txtNameContact.Text = objLoad.DeputyName;
            txtPhone.Text = objLoad.Phone;
            txtEmail.Text = objLoad.Email;
            txtSexDeputy.Text = objLoad.Sex ? Constraint.SexMale: Constraint.SexFemale;
            txtEmail.Text = objLoad.Email;
            txtAcount.Text = getAccout(objLoad.UserId);


        }
        private string getAccout (int? userID1)
        {
            int userID = (userID1 != null) ? (int)userID1 : 0;
            if (userID == 0)
                return "";

            Users user = null;
             using (var uow = new UnitOfWork())
             {
                 user = uow.UsersRepository.Find(userID);
                 uow.Commit();
             }
             if (user != null)
             {
                 return user.UserName;
             }
             return ""; 

        }

        private void XuLySauKhiUpdate(Deputy deputy)
        {
            if (deputy == null)
                return;
            LoadDeputy(deputy);
        }


         private void InititalizeForm(Company company)
        {

            txtName.Text = company.CompanyName;
            txtCode.Text = company.CompanyCode;
            txtAddress.Text = company.Address;
            txtTaxCode.Text = company.Taxcode;
            txtNoBrach.Text = company.Branch >=0 ? company.Branch.ToString() : "";
            txtNumberEmployee.Text = company.NumberOfEmployee >= 0 ? company.NumberOfEmployee.ToString() : "";
            txtNumberEmployee.Text = company.NumberOfEmployee != null ? company.NumberOfEmployee.ToString() : "";
            txtNote.Text = company.Note;
            txtSwiffcode.Text = company.SwiftCode;
            txtWebsite.Text = company.Website;         
           


            if (ValidationUtility.StringIsNull(company.PictureLogo) == false)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = Image.FromFile(PictureUtility.appDataDir + "//" + company.PictureLogo);

            }


            if (ValidationUtility.StringIsNull(company.Photo) ==false)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(PictureUtility.appDataDir + "//" + company.Photo);

            }

            LoadDeputy(company.MainDeputy);

        }

         private void InformationCustomer_Load(object sender, EventArgs e)
         {

             Deputy objmain = null;

             using (var uow = new UnitOfWork())
             {
                 objmain = uow.DeputyRepository.Find(_Account);
                 if (objmain != null)
                 {

                     _companySelect = uow.CompanyRepository.Find((int)objmain.CompanyId);


                 }
                 if(_companySelect !=null)
                 {
                     _companySelect.MainDeputy = objmain;
                 }


                 uow.Commit();
             }
             InititalizeForm(_companySelect);

         }


    }
}
