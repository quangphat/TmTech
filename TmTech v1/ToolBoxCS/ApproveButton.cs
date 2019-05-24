using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    [ToolboxItem(true)]
    public partial class ApproveButton : SimpleButton
    {
        private string bindingFor = "";
        public string Bindingfor
        {
            get
            {
                return bindingFor;
            }
            set
            {
                bindingFor = value;
            }
        }
        public ApproveButton()
        {
            InitializeComponent();
            this.Text = "Approve";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
