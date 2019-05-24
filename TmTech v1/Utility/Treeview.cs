using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;

namespace TmTech_v1.Utility
{
    public class TreeViewBank
    {
        protected readonly TreeView Treeview;

        public TreeViewBank(TreeView treeviewBind)
        {
            Treeview = treeviewBind;
        }

        public void BindDatasourcce()
        {
            try
            {
                BuidRootBank();
            }
            catch (System.Exception)
            {
                Treeview.Nodes.Clear();
            }
        }

        public void BuidRootBank()
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                IList<Model.Bank> lstBank = uow.BankBaseRepository.All();
                if (lstBank == null) return;
                TreeTagBank treeTag;
                foreach (Model.Bank bank in lstBank)
                {
                    TreeNode node = new TreeNode(bank.BankName);
                    treeTag = new TreeTagBank();
                    treeTag.NodeTye = TreeTagBank.Types.BankParrent;
                    treeTag.BankParrent = bank.BankId;
                    node.Tag = treeTag;
                    List<Model.BrankBank> lstSub = uow.BrankBankBaseRepository.GetAllBrankByBankID(bank.BankId.ToString());
                    if (lstSub == null) return;
                    BuildRootChild(lstSub, node);
                    Treeview.Nodes.Add(node);
                }
                uow.Commit();
            }
        }

        private void BuildRootChild(List<Model.BrankBank> lstSubCate, TreeNode cateNode)
        {
            foreach (Model.BrankBank childBank in lstSubCate)
            {
                TreeNode node = new TreeNode(childBank.BrankName);
                TreeTagBank treeTag = new TreeTagBank();
                treeTag.NodeTye = TreeTagBank.Types.BankChild;
                treeTag.BankParrent = childBank.BankId;
                treeTag.BankChild = childBank.BrankBankID;
                node.Tag = treeTag;
                cateNode.Nodes.Add(node);
            }
        }

        public class TreeTagBank
        {
            public enum Types
            {
                BankParrent,
                BankChild
            };

            public int BankParrent { get; set; }
            public int BankChild { get; set; }

            private Types _nodeType = Types.BankParrent;

            public Types NodeTye
            {
                get { return _nodeType; }
                set { _nodeType = value; }
            }
        }
    }
}