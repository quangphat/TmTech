using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class frmDeleteGroupsupplier : MetroForm
    {
        private GroupSupplier m_groupsupplier;
        private TreeNode m_treenode;
        public frmDeleteGroupsupplier(GroupSupplier groupsupplier, TreeNode treenode)
        {
            InitializeComponent();
            m_treenode = treenode;
            m_groupsupplier = groupsupplier;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SupplierRepository.deletegroup(m_groupsupplier);
                    uow.Commit();
                }
                m_treenode.TreeView.Nodes.Remove(m_treenode.TreeView.SelectedNode);
            
                this.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
