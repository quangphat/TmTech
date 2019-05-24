namespace TmTech_v1.ToolBoxCS
{
    public partial class NumberIntValidation: TextBoxValidation
    {

        public NumberIntValidation()
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
        }
     
    }
}
