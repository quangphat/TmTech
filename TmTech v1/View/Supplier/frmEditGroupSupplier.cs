using System;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using ModernUI.Forms;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmEditGroupSupplier : MetroForm
    {
        private GroupSupplier m_groupsupplier;
        private TreeNode m_treenode;
        public frmEditGroupSupplier (GroupSupplier groupsupplier, TreeNode treenode)
        {
            InitializeComponent();
            m_treenode = treenode;
            m_groupsupplier = groupsupplier;
        }

        private void saveupdate(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtGroupName.Text))
                {
                    lblNotify.SetText("không được bỏ trống", ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    return;
                }
                m_groupsupplier.GroupName = txtGroupName.Text;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SupplierRepository.Updategroupsupplier(m_groupsupplier);
                    uow.Commit();
                }
                m_treenode.Text = m_groupsupplier.GroupName;
                this.Close();
            }
            catch (Exception)
            {

                lblNotify.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed, 3000);
                return;
            }
            
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditGroupSupplier_Load(object sender, EventArgs e)
        {
            txtGroupName.Text = m_groupsupplier.GroupName;
        }

        private void bootstrapButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
