using System;
using System.Windows.Forms;
namespace TmTech_v1.ToolBoxCS
{
    public class TextBoxInt : AutoTextBox
    {
        public int MinLenghtTB { get; set; }
        public int MaxlenghtTB { get { return MaxLength; } set { MaxLength = value; } }
        public Boolean IsReadOnly { get { return ReadOnly; } set { ReadOnly = value; } }



        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }


    }
}
