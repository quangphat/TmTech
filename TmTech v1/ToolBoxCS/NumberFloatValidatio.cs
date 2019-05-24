namespace TmTech_v1.ToolBoxCS
{
    public partial class NumberFloatValidation : TextBoxValidation
    {
        
        public NumberFloatValidation()
        {
            InitializeComponent();
           
        }
       
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
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
