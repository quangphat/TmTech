using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class frmGroupSupplier : MetroForm
    {
        RequestFrmGroupSupplier requestFrmGroupSupplier;
        public frmGroupSupplier(RequestFrmGroupSupplier _requestFrmGroupSupplier)
        {
            requestFrmGroupSupplier = _requestFrmGroupSupplier;
            InitializeComponent();

        }

        private void GroupSupplier_Load(object sender, EventArgs e)
        {

            if(requestFrmGroupSupplier.groupsupplier !=null)
            {
                txtGroupName.Text = requestFrmGroupSupplier.groupsupplier.GroupName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtGroupName.Text) )
            {
                lblNotify.SetText("không được bỏ trống", ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            if( requestFrmGroupSupplier.groupsupplier!=null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    requestFrmGroupSupplier.groupsupplier.GroupName = txtGroupName.Text;
                    uow.SupplierRepository.Updategroupsupplier(requestFrmGroupSupplier.groupsupplier);
                    uow.Commit();
                }
                return;
            }
            Model.GroupSupplier groupSupplier = new Model.GroupSupplier()
            {
                GroupName = txtGroupName.Text,
                ParentGroup = 0
            };
            GroupSupplier groupSupplier1 = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                groupSupplier1 = uow.SupplierRepository.FindGroupName(txtGroupName.Text.ToLower());
               
            }

            if( groupSupplier1!=null)
            {
                lblNotify.SetText("đã tồn tại group name", ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            using (IUnitOfWork uow = new UnitOfWork())
            {
                int groupID = -1;
                try
                {
                    groupID = uow.SupplierRepository.AddGroup(groupSupplier);
                    uow.Commit();
                    groupSupplier.GroupId = groupID;
                }
                catch (Exception)
                {

                   
                }
               
            }
            if (groupSupplier.GroupId <0)
            {
                lblNotify.SetText( "Tạo mới thất bại"   , ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            else
            {
                TreeNode treenode = new TreeNode();
                TreeTagGroupSupplier treetag = new TreeTagGroupSupplier
                {
                    GroupId  =  groupSupplier.GroupId,
                    ParrentId  = 0

                };
                treenode.Tag = treetag;
                treenode.Text = groupSupplier.GroupName;
                treenode.ImageIndex = 1;
                requestFrmGroupSupplier.treeview.Nodes.Add(treenode);
                requestFrmGroupSupplier.treeview.Refresh();
                this.Close();
            }

        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNotify_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tạoNhómMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoMớiSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
