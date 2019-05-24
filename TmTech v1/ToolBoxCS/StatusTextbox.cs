using System.Drawing;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class StatusTextbox : AutoTextBox
    {
        public string StatusFieldName { get; set; }
        public enum StatusFlag { Waiting = 1, OK = 2, Cancel = 3 }
        public StatusTextbox()
        {
            InitializeComponent();
        }
        public void Display(string textToDisplay, StatusFlag flag = StatusFlag.Waiting)
        {
            if (flag == StatusFlag.OK)
            {
                this.BackColor = ((int)TmTechColor.Approved).ToColor();
                this.ForeColor = Color.White;
            }

            else if (flag == StatusFlag.Cancel)
            {
                this.BackColor = ((int)TmTechColor.Cancel).ToColor();
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            Text = textToDisplay;
            //Update();
            //thread1.Abort();
        }
        public void Display(string textToDisplay, int flag = 1)
        {
            if (flag == (int)StatusFlag.OK)
            {
                this.BackColor = ((int)TmTechColor.Approved).ToColor();
                this.ForeColor = Color.White;
            }

            else if (flag == (int)StatusFlag.Cancel)
            {
                this.BackColor = ((int)TmTechColor.Cancel).ToColor();
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            Text = textToDisplay;
            //Update();
            //thread1.Abort();
        }
        public void Display(int flag = 1)
        {
            if (flag == (int)StatusFlag.OK)
            {
                this.BackColor = ((int)TmTechColor.Approved).ToColor();
                this.ForeColor = Color.White;
            }

            else if (flag == (int)StatusFlag.Cancel)
            {
                this.BackColor = ((int)TmTechColor.Cancel).ToColor();
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            //Update();
            //thread1.Abort();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

        }
    }
}
