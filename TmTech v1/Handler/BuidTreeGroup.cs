using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Handler
{
    public class BuildTreeGroupModel
    {
        TreeView Treeview;
        List<GroupSupplier> lstGroupSupplier;
    }
    public class BuidTreeGroup
    {
        private readonly TreeView _treeview;

        public BuidTreeGroup(TreeView treeview)
        {
            _treeview = treeview;
            BuidRootParrent();
        }

        private void BuildNode(TreeNode treenode)
        {
            var listLoad = new List<GroupSupplier>();
            var tretagnode = treenode.Tag as TreeTagGroupSupplier;
            if (tretagnode == null)
                return;
            var _id = tretagnode.GroupId;
            var id = _id != null ? _id : -1;
            if (id == -1)
                return;
            listLoad.Clear();
            using (var uow = new UnitOfWork())
            {
                listLoad = uow.GroupSupplierRepository.ChildOfGroup(id);
            }
            foreach (var parrentGroupd in listLoad)
            {
                var treenode1 = new TreeNode();
                treenode1.Text = parrentGroupd.GroupName;
                var treetag = new TreeTagGroupSupplier
                {
                    GroupId = parrentGroupd.GroupId,
                    ParrentId = parrentGroupd.ParentGroup > 0 ? parrentGroupd.ParentGroup : 0
                };
                if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.ProcessStatus)
                {
                    treenode.ImageIndex = 2;
                }
                else if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.ApproveStatus)
                {
                    treenode.BackColor = ColorTranslator.FromHtml("#38b04a");
                }
                else if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.CancelStatus)
                {
                    treenode.BackColor = Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
                }
                else
                {
                    treenode.ImageIndex = 2;
                }

                treenode1.Tag = treetag;
                BuildNode(treenode1);
                treenode.Nodes.Add(treenode1);
            }
        }

        public void Refesh()
        {
            TreeNode treenode = _treeview.SelectedNode;
           _treeview.Nodes.Clear();
            BuidRootParrent();
            _treeview.SelectedNode = treenode;
        }
        public void BuidRootParrent()
        {
            List<GroupSupplier> listLoad;
            using (var uow = new UnitOfWork())
                listLoad = uow.GroupSupplierRepository.ParrentOfGroupRoot();

            foreach (var parrentGroupId in listLoad)
            {
                var treenode = new TreeNode();
                treenode.Text = parrentGroupId.GroupName;
                var treetag = new TreeTagGroupSupplier
                {
                    GroupId = parrentGroupId.GroupId,
                    ParrentId = parrentGroupId.ParentGroup > 0 ? parrentGroupId.ParentGroup : 0
                };
                treenode.Tag = treetag;
                _treeview.Nodes.Add(treenode);
            }
            foreach (TreeNode treeNode in _treeview.Nodes)
            {
                var tretagnode = treeNode.Tag as TreeTagGroupSupplier;
                if (tretagnode == null)
                    continue;
                var _id = tretagnode.GroupId;
                var id = _id != null ? _id : -1;
                if (id == -1)
                    continue;
                listLoad.Clear();
                using (var uow = new UnitOfWork())
                    listLoad = uow.GroupSupplierRepository.ChildOfGroup(id);

                foreach (var parrentGroupd in listLoad)
                {
                    var treenode2 = new TreeNode();
                    treenode2.Name = parrentGroupd.GroupId.ToString();
                    treenode2.Text = parrentGroupd.GroupName;
                    var treetag = new TreeTagGroupSupplier
                    {
                        GroupId = parrentGroupd.GroupId,
                        ParrentId =
                            parrentGroupd.ParentGroup > 0 ? parrentGroupd.ParentGroup:0
                    };

                    if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.ProcessStatus)
                    {
                        treenode2.ImageIndex = 2;
                    }
                    else if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.ApproveStatus)
                    {
                        treenode2.BackColor = ColorTranslator.FromHtml("#38b04a");
                    }
                    else if (parrentGroupd.ApproveStatusId == ConstraintApproveStatus.CancelStatus)
                    {
                        treenode2.BackColor = Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
                    }
                    else
                    {
                        treenode2.ImageIndex = 2;
                    }
                    treenode2.Tag = treetag;
                    BuildNode(treenode2);
                    treeNode.Nodes.Add(treenode2);
                }
            }

            _treeview.Refresh();
        }
    }
}
