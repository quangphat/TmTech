namespace TmTech_v1.ToolBoxCS
{
   public class TaxcodeTextbox :AutoTextBox
    {
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '_'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            
        }
        
    }
}
