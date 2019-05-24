using ModernUI.Forms;
using System;
using TmTech.Resource;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class FrmInputBank : MetroForm
    {
        public FrmInputBank()
        {
            InitializeComponent();
            lableMessage.Text = "";
        }
        AutoTextBox m_texbox;
        public FrmInputBank(AutoTextBox textboxInput)
        {
            m_texbox = textboxInput;
            InitializeComponent();
            lableMessage.Text = "";
        }

        private void AddItemBank(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
            {
                lableMessage.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
                m_texbox.Text += txtBankName.Text + "_" + txtAccountName.Text + "_" + txtAccountNumber.Text + ";";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
