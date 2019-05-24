using System;
using System.Collections.Generic;
using ModernUI.Forms;
using TmTech_v1.ValidateData;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public partial class PopupMessage : MetroForm
    {

        private static PopupMessage _instance;
        private List<ErrorData> _lstData = null;
        private GridUtility gridUtility;
       
        public static PopupMessage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PopupMessage();
                }
                return _instance;
            }
        }

        public PopupMessage()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadMessage(List<ErrorData> lstData)
        {
            if (_lstData == null)
                _lstData = new List<ErrorData>();
            gridUtility.BindingData(_lstData);
            this.ShowDialog();
           
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
