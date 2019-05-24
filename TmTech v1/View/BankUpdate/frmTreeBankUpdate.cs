using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmTreeBankUpdate : UserControl
    {
        
        public frmTreeBankUpdate()
        {
            InitializeComponent();
        }

        private void frmTreeBankUpdate_Load(object sender, EventArgs e)
        {
            loadParentNode();
            treeList1.ExpandAll();
            lblUsername.Text = UserManagement.UserSession.UserName;
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
        }

        private object createObject(Model.Bank bank = null, BrankBank branch = null)
        {
            object obj = null;
            //insert for bank
            if (bank != null && branch == null)
            {
                obj = new object[]
                {
                    bank.BankId,
                    bank.BankCode,
                    bank.BankName,
                    bank.Address,
                    bank.Phone,
                    bank.Fax,
                    bank.Email,
                    bank.Note,
                    bank.CreateDate,
                    bank.CreateBy,
                    bank.ModifyDate,
                    bank.ModifyBy
                };
            }
            if (bank == null && branch != null)
            {
                obj = new object[]
                {
                    branch.BrankBankID,
                    null,//code
                    branch.BrankName,
                    branch.BrankAddress,
                    branch.Phone,
                    null,//fax
                    null,//email
                    branch.Note,
                    branch.CreateDate,
                    branch.CreateBy,
                    branch.ModifyDate,
                    branch.ModifyBy
                };
            }
            return obj;
        }

        private TreeListNode findBankNode(string bankId)
        {
            List<TreeListNode> rootNode = treeList1.Nodes.ToList();
            foreach (var v in rootNode)
            {
                if (v.GetValue("BankId").ToString() == bankId)
                {
                    return v;
                }
            }
            return null;
        }

        #region Delegate
        private void InsertOrUpdate(Model.Bank bank, Utility.CRUD cru, Model.BrankBank branch = null)
        {
            if (cru == CRUD.Insert)
            {
                //add parent node BANK
                if (bank != null && branch == null)
                {
                    object obj = createObject(bank);
                    TreeListNode node = treeList1.AppendNode(obj, treeList1.AllNodesCount);
                    node.Tag = "Parent";
                }
                //add child node BRANCH
                if (branch != null && bank != null)
                {
                    object obj2 = createObject(null, branch);
                    //Find parent node
                    TreeListNode node = treeList1.AppendNode(obj2, findBankNode(bank.BankId.ToString()));
                    node.Tag = "Child";
                }
            }
            if(cru == CRUD.Update)
            {
                //update parent node BANK
                if (bank != null && branch == null)
                {
                    TreeListNode node = treeList1.Selection[0];
                    node.SetValue("BankCode", bank.BankCode);
                    node.SetValue("BankName", bank.BankName);
                    node.SetValue("Phone", bank.Phone);
                    node.SetValue("Fax", bank.Fax);
                    node.SetValue("Email", bank.Email);
                    node.SetValue("Address", bank.Address);
                    node.SetValue("Note", bank.Note);
                    node.SetValue("ModifyDate", bank.ModifyDate);
                    node.SetValue("ModifyBy", bank.ModifyBy);
                }
                //update child node BRANCH
                if (branch != null && bank != null)
                {
                    TreeListNode node = treeList1.Selection[0];
                    node.SetValue("BankName", branch.BrankName);
                    node.SetValue("Phone", branch.Phone);
                    node.SetValue("Address", branch.BrankAddress);
                    node.SetValue("Note", branch.Note);
                    node.SetValue("ModifyDate", branch.ModifyDate);
                    node.SetValue("ModifyBy", branch.ModifyBy);
                }
            }


        }

        #endregion

        #region Load Parent and Child nodes
        private void loadParentNode()
        {
            IList<Model.Bank> lstBank = new List<Model.Bank>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBank = uow.BankBaseRepository.All();
                uow.Commit();
            }
            TreeListNode rootNode;
            //add parent node
            foreach (var v in lstBank)
            {
                object obj = createObject(v);
                rootNode = treeList1.AppendNode(obj, null, v.BankId);
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    rootNode.HasChildren = uow.BankBaseRepository.hasBranch(v);
                    uow.Commit();
                }
                //check children
                if (rootNode.HasChildren)
                    rootNode.Tag = "Child";
                else
                    rootNode.Tag = "Parent";
                
            }
            //////////////////////
        }

        //load for ChildNode
        private void treeList1_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                IList<BrankBank> lstBranch = new List<BrankBank>();
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstBranch = uow.BrankBankBaseRepository.GetAllBrankByBankID(e.Node.GetDisplayText("BankId"));
                    uow.Commit();
                }
                //add childnode
                e.Node.Nodes.Clear();
                foreach (var v in lstBranch)
                {
                    object obj = createObject(null, v);
                    TreeListNode node =treeList1.AppendNode(obj, e.Node, e.Node.Tag);
                    node.Tag = true;
                }

                e.Node.Tag = "Parent";
            }
        }

        #endregion

        #region Insert row
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmChooseToCreate obj = new frmChooseToCreate();
            obj.insert = InsertOrUpdate;
            obj.ShowDialog();
        }
        #endregion

        #region Buttons Reload, Search
        private void btnReload_Click(object sender, EventArgs e)
        {
            treeList1.ClearNodes();
            loadParentNode();
            treeList1.ExpandAll();
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
            treeList1.ExpandAll();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtSearch_ButtonClick(null, null);
            }
        }

        private void Search(string txtSearch)
        {
            if (string.IsNullOrWhiteSpace(txtSearch)) return;
            IList<Model.BrankBank> lstBranch;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstBranch = uow.BrankBankBaseRepository.Search(txtSearch);
                uow.Commit();
            }
            if (lstBranch.Count <= 0) return;
            //display to tree
            //clear all nodes
            treeList1.ClearNodes();
            //add parent node (BANK)
            TreeListNode root = null;
            //only apply for a table has been sorted by ParentId (BankId)
            foreach (var v in lstBranch)
            {
                if (treeList1.AllNodesCount == 0)
                {
                    object obj1 = createObject(v.Bank);
                    root = treeList1.AppendNode(obj1, null);
                    root.HasChildren = true;
                }
                else
                {
                    int x = Convert.ToInt32(root.GetDisplayText("BankId"));
                    if (x != v.BankId)
                    {
                        object obj3 = createObject(v.Bank);
                        root = treeList1.AppendNode(obj3, null);
                        root.HasChildren = true;
                    }
                }

                object obj2 = createObject(null, v);
                treeList1.AppendNode(obj2, root);
            }
        }

        #endregion
        
        #region Get record as Model
        private Model.Bank getBankRecord(TreeListNode node)
        {
            if (node == null) return null;

            Model.Bank bank = new Model.Bank();
            UtilityFunction.ConvertTreeListNodeToObj<Model.Bank>(treeList1, node, bank);
            //bank.BankId = Convert.ToInt32(node.GetDisplayText("BankId"));
            //bank.BankCode = node.GetDisplayText("BankCode");
            //bank.BankName = node.GetDisplayText("BankName");
            //bank.Address = node.GetDisplayText("Address");
            //bank.Phone = node.GetDisplayText("Phone");
            //bank.Fax = node.GetDisplayText("Fax");
            //bank.Email = node.GetDisplayText("Email");
            //bank.Note = node.GetDisplayText("Note");
            //bank.CreateDate = string.IsNullOrWhiteSpace(node.GetDisplayText("CreateDate"))==false? Convert.ToDateTime(node.GetDisplayText("CreateDate")):DateTime.Now;
            //bank.CreateBy = node.GetDisplayText("CreateBy");
            //if (!string.IsNullOrEmpty(node.GetDisplayText("ModifyDate")))
            //    bank.ModifyDate = Convert.ToDateTime(node.GetDisplayText("ModifyDate"));
            //bank.ModifyBy = node.GetDisplayText("ModifyBy");
            return bank;
        }

        private BrankBank getBranchBankRecord(TreeListNode node)
        {
            if (node == null) return null;
            BrankBank branch = new BrankBank();
            UtilityFunction.ConvertTreeListNodeToObj<Model.BrankBank>(treeList1, node, branch);
            branch.BrankBankID = Convert.ToInt32(node.GetDisplayText("BankId"));
            branch.BrankName = node.GetDisplayText("BankName");
            branch.BrankAddress = node.GetDisplayText("Address");
            //branch.Phone = node.GetDisplayText("Phone");
            //branch.Note = node.GetDisplayText("Note");
            //if (!string.IsNullOrEmpty(node.GetDisplayText("CreateDate")))
            //    branch.CreateDate = Convert.ToDateTime(node.GetDisplayText("CreateDate"));
            //branch.CreateBy = node.GetDisplayText("CreateBy");
            //if (!string.IsNullOrEmpty(node.GetDisplayText("ModifyDate")))
            //    branch.ModifyDate = Convert.ToDateTime(node.GetDisplayText("ModifyDate"));
            //branch.ModifyBy = node.GetDisplayText("ModifyBy");
            branch.Bank = getBankRecord(node.ParentNode);
            return branch;
        }
        #endregion

        #region Update row
        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            if (hi.Node!=null)
            {
                TreeListNode node = treeList1.Selection[0];
                if (node.Tag.ToString() =="Parent") //is Parent (BANK)
                {
                    frmEditBankUpdate obj1 = new frmEditBankUpdate(getBankRecord(node));
                    obj1.updateBank = InsertOrUpdate;
                    obj1.ShowDialog();
                }
                else //is Child (Branch)
                {
                    BrankBank bran = getBranchBankRecord(node);
                    frmEditBranchBankUpdate obj2 = new frmEditBranchBankUpdate(bran);
                    obj2.updateBranch = InsertOrUpdate;
                    obj2.ShowDialog();
                }
            }
            
        }
        #endregion

        #region Status labels
        private void treeList1_Click(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(MousePosition));
            if (hi.Node != null)
            {
                //Reset
                lblCreateBy.Text = "";
                lblCreateDate.Text = "";
                lblModifyBy.Text = "";
                lblModifyDate.Text = "";
                //Renew
                if (!string.IsNullOrEmpty(hi.Node.GetDisplayText("CreateDate")))
                    lblCreateDate.Text = UtilityFunction.DateTimeToString(Convert.ToDateTime(hi.Node.GetDisplayText("CreateDate")));
                lblCreateBy.Text = hi.Node.GetDisplayText("CreateBy");
                if (!string.IsNullOrEmpty(hi.Node.GetDisplayText("ModifyDate")))
                    lblModifyDate.Text = UtilityFunction.DateTimeToString(Convert.ToDateTime(hi.Node.GetDisplayText("ModifyDate")));
                lblModifyBy.Text = hi.Node.GetDisplayText("ModifyBy");
            }
        }
        #endregion

        #region Delete node
        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(FormUtility.MsgDelete() == DialogResult.Yes)
                {
                    TreeListNode node = treeList1.Selection[0];
                    if (node == null) return;
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            if (node.Tag.ToString() == "Parent")
                            {
                                uow.BankBaseRepository.Remove(getBankRecord(node));
                            }
                            else
                            {
                                uow.BrankBankBaseRepository.Remove(getBranchBankRecord(node));
                            }
                            uow.Commit();
                        }
                        //refresh data source
                        btnReload.PerformClick();
                        labelNotify1.SetText(UI.removesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                    }
                    catch
                    {
                        labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    }
                }
                e.Handled = true;
            }
        }
        #endregion
    }
}
