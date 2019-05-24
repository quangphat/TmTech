using System;
using System.Drawing;
using System.Windows.Forms;
using Tmtech.SDK.Control.Model;

namespace Tmtech.SDK.Control
{
    public class AutoTextBox : TextBox
    {
        public string BindingName { get; set; }
        public string BindingFor { get; set; }
        public bool IsPassword { get; set; }
        public bool IsRequire { get; set; }

        public AutoTextBox()
        {
            if (IsPassword)
            {
                this.UseSystemPasswordChar = true;
                this.PasswordChar =char.Parse(Constraint.PassWordChar);
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            ResetColorTextBox(this);
            base.OnLeave(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            BackColor = Color.LightYellow;
            ForeColor = Color.Black;
        }

        private void ResetColorTextBox(TextBox txtBoxToChange)
        {
            if (ForeColor == Color.Red)
            {
                return;
            }
            txtBoxToChange.BackColor = Color.White;
        }
    }
}
