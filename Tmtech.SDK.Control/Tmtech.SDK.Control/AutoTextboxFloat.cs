using System;
using System.Windows.Forms;

namespace Tmtech.SDK.Control
{
    class AutoTextboxFloat : AutoTextBox
    {
        public int MinLenghtTb { get; set; }
        public int MaxlenghtTb
        {
            get { return MaxLength; }
            set { MaxLength = value; }
        }

        public Boolean IsReadOnly
        {
            get { return ReadOnly; }
            set { ReadOnly = value; }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
