using System;
using System.Windows.Forms;

namespace TmTech_v1.View
{
    public partial class frmUserLeftView : UserControl
    {
        frmPrimary m_frmPrimary;
        public frmUserLeftView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            m_frmPrimary = Application.OpenForms["frmPrimary"] as frmPrimary;
        }

        private void itemUser_Click(object sender, EventArgs e)
        {
            m_frmPrimary.ItemUserClick();
        }

        private void itemUserGroup_Click(object sender, EventArgs e)
        {
            m_frmPrimary.itemUserGroupClick();
        }}
}
