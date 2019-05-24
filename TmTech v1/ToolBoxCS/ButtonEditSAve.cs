using ModernUI.Controls;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class ButtonEditSave : BootstrapButton
    {
        public enum ButtonStatus { Edit = 1, Save = 2 };
        private ButtonStatus status = ButtonStatus.Edit;
        public ButtonStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                if (status == ButtonStatus.Edit)
                    Text = "Sửa";
                if (status == ButtonStatus.Save)
                    Text = "Lưu";
            }
        }
        public ButtonEditSave()
        {
            InitializeComponent();
            BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
