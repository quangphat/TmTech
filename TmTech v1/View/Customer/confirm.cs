using ModernUI.Forms;
using TmTech_v1.Model;

namespace TmTech_v1.View.Customer
{
    public partial class frmConform : MetroForm
    {
        public frmConform(RequestConfirmForm requestConfirmForm)
        {
            InitializeComponent();
            txtStatusCurrent.Text = requestConfirmForm.CurrentStatus;
        }

        private void bootstrapButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {

        }

        private void bootstrapButton2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
