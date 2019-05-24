using System;
using System.Windows.Forms;
using ModernUI.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.ToolBoxCS
{
    public partial class DialougeTreeviewGroupBank : MetroForm
    {
        private readonly DiloalugeTreviewParameter parameterTrans;

        public DialougeTreeviewGroupBank()
        {
            InitializeComponent();
        }

        public DialougeTreeviewGroupBank(DiloalugeTreviewParameter parameter)
        {
            InitializeComponent();
            parameterTrans = parameter;
            if (parameterTrans.IsInsert)
            {
                pnelMain.Controls.Remove(pnelOld);
            }
            else

            {
                pnelMain.Controls.Remove(pnelNew);
                txtOld.Text = parameterTrans.TextNodeParrent;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNew.Text.Trim() == string.Empty)
            {
                lbleMessage.SetText("không được để trống, nhập lại", LabelNotify.EnumStatus.Other);
                return;
            }
            if (parameterTrans.IsInsert)
            {
                var groupInsert = new GroupSupplier
                {
                    ParentGroup = int.Parse(parameterTrans.ParrentId),
                    GroupName = txtNew.Text
                };

                var treeInsert = parameterTrans.Treenode;

                if (treeInsert.Parent == null)
                    groupInsert.ParentGroup = 0;


                var id = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    id = uow.SupplierRepository.AddGroup(groupInsert);
                    uow.Commit();
                }
                if (id > 0)
                    groupInsert.Id = id.ToString();

                var treenode = new TreeNode
                {
                    Text = txtNew.Text
                };
                TreeTagGroupSupplier treetag = new TreeTagGroupSupplier
                {
                    ParrentId = groupInsert.ParentGroup,
                    GroupId = groupInsert.GroupId
                };

                treenode.Tag = treetag;
                if (!parameterTrans.TyepParrent)
                    if (treeInsert.Nodes.Count > 0)
                    {
                        if (treeInsert.Parent != null)
                            treeInsert.Parent.Nodes.Add(treenode);
                    }
                    else
                    {
                        treeInsert.Nodes.Add(treenode);
                    }
                else

                    try
                    {
                        if (treeInsert.Parent != null)
                            treeInsert.Parent.Nodes.Add(treenode);
                        else
                        {
                            treeInsert.TreeView.Nodes.Add(treenode);
                        }
                    }
                    catch (Exception)
                    {
                        treeInsert.TreeView.Nodes.Add(treenode);
                    }
                treeInsert.TreeView.Tag = treeInsert;
                treeInsert.TreeView.Refresh();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}