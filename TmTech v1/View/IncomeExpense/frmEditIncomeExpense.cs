using System;


namespace TmTech_v1.View
{
    public partial class frmEditIncomExpense : ModernUI.Forms.MetroForm
    {
        public delegate void delgGetValue(string value);
        public delgGetValue value;
        public frmEditIncomExpense()
        {
            InitializeComponent();
        }

        private void frmEditIncomeExpense_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (autoTextBox1.Text == "")
                return;
            if (value != null)
                value(autoTextBox1.Text);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
