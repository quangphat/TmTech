using System.Windows.Forms;

namespace TmTech_v1.Utility
{
    public static class UtilityMessageBox
    {


        public static DialogResult WarningOpeartor(string strWarningAlert)
        {
            return MessageBox.Show(strWarningAlert, NotificationMessage.MsgWarningOperator, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
        public static DialogResult WarningOpeartor(string strWarningAlert,string capton)
        {
            return MessageBox.Show(strWarningAlert, NotificationMessage.MsgWarningOperator, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        public static void ShowText(string strTextShow)
        {
             MessageBox.Show(strTextShow, NotificationMessage.MsgWarningOperator, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
       
    }

}
