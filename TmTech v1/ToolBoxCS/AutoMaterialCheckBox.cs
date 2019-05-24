using ModernUI.Controls;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class AutoMaterialCheckBox : MaterialCheckBox
    {
        private string bindingName;
        public string BindingName
        {
            get
            {
                return bindingName;
            }
            set
            {
                bindingName = value;
            }
        }
        private string bindingFor = "";
        public string BindingFor
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
        public AutoMaterialCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
