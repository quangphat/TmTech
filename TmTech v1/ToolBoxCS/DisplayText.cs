using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public class DisplayText :TextBox
    {
        public bool IsRead = true;
        public DisplayText()
        {
            ReadOnly = true;
        }

    }
}
