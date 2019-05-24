using ModernUI.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public class CboBindBank : MetroSearchComboBox
    {
        public CboBindBank()
        {

        }
        protected override void OnCreateControl()
        {
            ComboboxUtility.BindBank(this);
            this.SelectedValueChanged += CboBindBank_SelectedValueChanged;
            this.SelectedItem = null;
            base.OnCreateControl();
        }


        private void CboBindBank_SelectedValueChanged(object sender, EventArgs e)
        {
           
            object m_bankSelect = this.SelectedItem;
            string adrress = string.Empty;
            if (m_bankSelect != null)
            {
                var properti = m_bankSelect.GetType().GetProperties();
                ;
                foreach (var propertiItem in properti)
                {
                    if (!propertiItem.Name.ToLower().Contains("ddress"))
                        continue;

                    var addresstemp = propertiItem.GetValue(m_bankSelect);
                    if (addresstemp != null)
                        adrress = addresstemp.ToString();
                }
            }

                var textboxAddress = this.FindForm().Controls.Find("txtAddress", true).FirstOrDefault();
                if (textboxAddress == null)
                    return;
                TextBox txtResulf = textboxAddress as TextBox;
                if (txtResulf == null)
                    return;
                txtResulf.Text = adrress;

        }
    }
}
