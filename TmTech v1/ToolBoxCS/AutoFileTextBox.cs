using System;
using System.Windows.Forms;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public partial class AutoFileTextBox : TextBox
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
        public string FileName { get; set; }
        public string FilePath{get;set;}
        public AutoFileTextBox()
        {
            InitializeComponent();
            FileName = FilePath = string.Empty;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            //base.OnDoubleClick(e);
            FileUtility.OpenToView(this.FileName);
        }
    }
}
