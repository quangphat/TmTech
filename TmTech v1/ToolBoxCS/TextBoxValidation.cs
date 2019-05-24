using System;
using System.Drawing;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class TextBoxValidation : AutoTextBox
    {
        private bool allowNull = false;
        public bool AllowNull
        {
            get { return allowNull; }
        }
        public TextBoxValidation()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (Text!="null")
            {
                if (BackColor == ((int)TmTechColor.Approved).ToColor() || BackColor == ((int)TmTechColor.Cancel).ToColor())
                    ForeColor = Color.White;
                else
                    ForeColor = Color.Black;
            }
        }
        protected override void OnGotFocus(EventArgs e)
        {
            if (ForeColor == Color.Red)
                Clear();
        }
    }
}
