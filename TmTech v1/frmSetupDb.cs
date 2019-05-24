using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;

namespace TmTech_v1
{
    public partial class frmSetupDb : MetroForm
    {
        Dictionary<int, string> lstAuthenticationType;
        public frmSetupDb()
        {
            InitializeComponent();
            lstAuthenticationType = new Dictionary<int, string>();
            lstAuthenticationType.Add(1, "Window Authentication");
            lstAuthenticationType.Add(2, "SQL Server Authentication");
        }


        private void frmSetupDb_Load(object sender, EventArgs e)
        {
            cbbAuthenticationType.DataSource = new BindingSource(lstAuthenticationType,null);
            cbbAuthenticationType.DisplayMember = "Value";
            cbbAuthenticationType.ValueMember = "Key";
        }

        private void cbbAuthenticationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAuthenticationType.SelectedValue.ToString() == "1")
            {
                txtUsername.Enabled = txtPassword.Enabled = false;
            }
            if (cbbAuthenticationType.SelectedValue.ToString() == "2")
            {
                txtUsername.Enabled = txtPassword.Enabled = true;
            }
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            bool result = DbTmTech.TestConnect(txtServer.Text, "TmTech");
            if (result == false)
            {
                FlatMessageBox.FlatMsgBox.Show("Không thể kết nối");
                return;
            }
            if (result == true)
                FlatMessageBox.FlatMsgBox.Show("Thành công");
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            bool result = DbTmTech.ConnectDb(txtServer.Text, "TmTech", int.Parse(cbbAuthenticationType.SelectedValue.ToString()),txtUsername.Text,txtPassword.Text);
            if (result == false)
            {
                FlatMessageBox.FlatMsgBox.Show("Không thể kết nối");
                return;
            }
            this.Close();
        }
    }
}
