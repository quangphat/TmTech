using DevExpress.XtraEditors;
using System.ComponentModel;
namespace TmTech_v1.ToolBoxCS
{
    [ToolboxItem(true)]
    public partial class AutoXDatetime : DateEdit
    {
        private string bindingName;
        public string BindingName
        {
            get
            {
                return bindingName;
            }
            set
            {
                bindingName = value;
            }
        }
        private string bindingFor = "";
        public string BindingFor
        {
            get
            {
                return bindingFor;
            }
            set
            {
                bindingFor = value;
            }
        }
        public AutoXDatetime()
        {
            InitializeComponent();
        }

        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    base.OnPaint(pe);
        //}
    }
}
