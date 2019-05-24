using ModernUI.Controls;
using System;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class AutoSearchCombobox : MetroSearchComboBox
    {

        public bool RequireInput { get; set; }
             
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
        //true to get selectedtext, false to get selectedvalue;
        private bool getSelectedText = false;
        public bool GetSelectedText
        {
            get
            {
                return getSelectedText;
            }
            set
            {
                getSelectedText = value;
            }
        }
        public AutoSearchCombobox()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }
        protected override void OnSelectionChangeCommitted(EventArgs e)
        {
            base.OnSelectionChangeCommitted(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
