using ModernUI.Forms;
using System.Timers;

namespace TmTech_v1.View.Supplier
{
    public partial class lableMesssage : MetroForm
    {
        private Timer _timer;
        string _text = string.Empty;
        public lableMesssage( string information)
        {
            InitializeComponent();
            _text = information;


        }

        private void lableMesssage_Load(object sender, System.EventArgs e)
        {
            lblInformationMessage.Text = _text;

        }
    }
}
