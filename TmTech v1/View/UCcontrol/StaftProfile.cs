using System;
using System.Windows.Forms;
using TmTech_v1.Interface;


namespace TmTech_v1.View.UCcontrol
{
    public partial class StaftProfile : UserControl
    {
        private int _idStaff = 1;
        public StaftProfile( )
        {
            InitializeComponent();
         //   _idStaff = idstaft;
            _idStaff = 1;
        }
        public int  Idstaff
        {
            get { return _idStaff; }
            set { _idStaff = value; }
        }

        private void StaftProfile_Load(object sender, EventArgs e)
        {
            txtStaftName.ReadOnly = txtID.ReadOnly = txtPhone.ReadOnly = txtEmail.ReadOnly = true;
            cboSex.Enabled = false;

            if (_idStaff < 1)
                return;

            try
            {
                Model.Staff stafter;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    stafter = uow.StaffRepository.Find(_idStaff);
                    uow.Commit();
                }
                if (stafter != null)
                {
                    txtStaftName.Text = stafter.StaffName;
                    txtID.Text = stafter.StaffId.ToString();
                    txtPhone.Text = stafter.Phone;
                    txtEmail.Text = stafter.Email;
                    //if (stafter.sre == true)
                    //{
                    //    cboSex.SelectedIndex = 0;

                    //}
                    //else cboSex.SelectedIndex = 1;
                }
            }
            catch (Exception)
            {

                return;
            }
           
        }

        private void pnStaffInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        
        

    }
}
