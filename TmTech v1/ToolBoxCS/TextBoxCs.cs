using System;
using System.Windows.Forms;
using TmTech_v1.Model;

namespace TmTech_v1.ToolBoxCS
{
    public class TextBoxCs : AutoTextBox
    {
        public enum TypeDataTextBox
        {
            String,
            Int,
            Float,
            Decimal,
            Double
        };

        public TypeDataTextBox TypeData { get; set; }
        public TextBoxCs()
        {
            TypeData = TypeDataTextBox.String;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (TypeData)
            {
                case TypeDataTextBox.Int:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                case TypeDataTextBox.Float:
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
                    break;
                case TypeDataTextBox.Decimal:
                    break;
                case TypeDataTextBox.Double:
                    break;

            }
            base.OnKeyPress(e);
        }
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                string tempValue = value;
                switch (TypeData)
                {
                    case TypeDataTextBox.Int:
                        if (string.IsNullOrEmpty(tempValue))
                        {
                            base.Text = DefautValueType.DefautValuesInt;
                            return;
                        }
                        try
                        {
                            int valuetemp = Convert.ToInt32(tempValue);
                            base.Text = valuetemp.ToString();
                        }
                        catch (Exception)
                        {

                            base.Text = DefautValueType.DefautValuesInt;
                        }
                        break;
                    case TypeDataTextBox.Float:
                        if (string.IsNullOrEmpty(tempValue))
                        {
                            base.Text = DefautValueType.DefautValuesFloat;
                            return;
                        }
                        try
                        {
                            float valuetemp = float.Parse(tempValue);
                            base.Text = valuetemp.ToString();
                        }
                        catch (Exception)
                        {

                            base.Text = DefautValueType.DefautValuesFloat;
                        }
                        break;
                    case TypeDataTextBox.Double:
                        if (string.IsNullOrEmpty(tempValue))
                        {
                            base.Text = DefautValueType.DefautValuesDouble;
                            return;
                        }
                        try
                        {
                            double valuetemp = double.Parse(tempValue);
                            base.Text = valuetemp.ToString();
                        }
                        catch (Exception)
                        {

                            base.Text = DefautValueType.DefautValuesDouble;
                        }
                        break;
                    case TypeDataTextBox.String:
                        if (string.IsNullOrEmpty(tempValue))
                        {
                            base.Text = DefautValueType.DefautValueString;
                            return;
                        }

                        base.Text = tempValue;
                        break;

                }
            }
        }

    }
}
