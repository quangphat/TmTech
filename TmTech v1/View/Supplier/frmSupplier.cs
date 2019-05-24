using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Handler;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public sealed partial class FrmSupplier : UserControl
    {

        GridUtility gridUtility1;
        Model.Supplier m_Suplier;
        SubSupplier m_Subsupplier;
        Users m_User;
        TreeNode currentNode;
        private TreeNode m_previousSelectedNode;

        public FrmSupplier()
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            m_Suplier = null;
            m_Subsupplier = null;
            m_User = null;
            IGridviewContextMenu ctx = new CompanyContextMenu();
            IGridviewContextMenu ctxDeputy = new DeputyContextMenu();
            gridUtility1 = new GridUtility(gridControl1, ctxDeputy);
            ImageList myImageList = new ImageList();
            myImageList = new ImageList();
            myImageList.Images.Add(TmTech_v1.Properties.Resources.iconSelect);
            myImageList.Images.Add(TmTech_v1.Properties.Resources.folder);
            myImageList.Images.Add(TmTech_v1.Properties.Resources.warming);
            treeviewsupplier.ImageList = myImageList;
            treeviewsupplier.SelectedImageIndex = 0;
            treeviewsupplier.DrawNode += Treeviewsupplier_DrawNode;
        }

        private void Treeviewsupplier_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            TreeNodeStates state = e.State;
            Font font = e.Node.NodeFont ?? e.Node.TreeView.Font;
            Color fore = e.Node.ForeColor;
            if (fore == Color.Empty) fore = e.Node.TreeView.ForeColor;
            if (e.Node == e.Node.TreeView.SelectedNode)
            {
                fore = SystemColors.HighlightText;
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, fore, SystemColors.Highlight);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, fore, TextFormatFlags.GlyphOverhangPadding);
            }
        }

        private void Frmsupplier_load(object sender, EventArgs e)
        {
            LoadTreeview();
        }

        private void LoadTreeview()
        {
            BuidTreeGroup obi = new BuidTreeGroup(this.treeviewsupplier);

            foreach (TreeNode treenodeSelect in treeviewsupplier.Nodes)
            {
                if (treenodeSelect.Parent == null)
                {
                    treenodeSelect.ImageIndex = 1;
                    //treeviewsupplier.ImageIndex = 1;

                }
                else
                    continue;
            }
            foreach (TreeNode treenodeSelect in treeviewsupplier.Nodes)
            {
                if (treenodeSelect.Nodes.Count > 0)
                {
                    SelectDisplayNode(treenodeSelect.Nodes[0]);
                    treenodeSelect.Nodes[0].Parent.ExpandAll();
                    treeviewsupplier.SelectedNode = treenodeSelect.Nodes[0];

                    break;
                }
            }


        }

        private void SelectDisplayNode(TreeNode node)
        {
            if (node == null) return;
            if (node.Nodes.Count > 1) return;
            TreeTagGroupSupplier treetag = node.Tag as TreeTagGroupSupplier;
            if (treetag == null) return;
            IList<SubSupplier> lstDeputy = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Suplier = uow.SupplierRepository.FindByGroupSupplierID(treetag.GroupId);
                if (m_Suplier != null)
                    lstDeputy = uow.SubSupplierRepository.GetbySupplier(m_Suplier);
                uow.Commit();
            }
            InitializeForm(m_Suplier);
            Loadsubsupplier(m_Suplier, lstDeputy);
        }
        private void Loadsubsupplier(Model.Supplier supplier, IList<SubSupplier> lstDeputy = null)
        {
            if (m_Suplier == null) return;
            if (lstDeputy == null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstDeputy = uow.SubSupplierRepository.GetbySupplier(supplier);
                    uow.Commit();
                }
            }
            gridUtility1.BindingData<SubSupplier>(lstDeputy);
            if (lstDeputy != null)
            {
                m_Subsupplier = lstDeputy.Where(p => p.IsMain == true).FirstOrDefault();
                if (m_Subsupplier == null) m_Subsupplier = new SubSupplier();
                InitializeForm(m_Subsupplier);
            }
            //cbbIsMainDeputy.Checked = deputy.IsMain;
        }
        private void InitializeForm(Model.Supplier supplier)
        {
            if (supplier == null)
                supplier = new Model.Supplier();
            txtsupplierName.Display(supplier.ApproveStatusId);
            CoverObjectUtility.SetAutoBindingData(this, supplier);
            if (supplier.SupplierId <= 0)
                btnsavesupplier.Visible = false;
            else
                btnsavesupplier.Visible = true;
        }
        private void InitializeForm(SubSupplier subsupplier)
        {
            m_User = subsupplier.User;
            if (subsupplier.User == null)
                m_User = new Users();
            CoverObjectUtility.SetAutoBindingData(this, m_User);
            CoverObjectUtility.SetAutoBindingData(this, subsupplier);
            cbbIsMainDeputy.Checked = subsupplier.IsMain;
            cbActive.Checked = subsupplier.IsActive;
            if (subsupplier.User.Sex == true)
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            if (subsupplier.SubSupplierId <= 0)
                btnSaveDeputy.Visible = false;
            else
                btnSaveDeputy.Visible = true;
        }


        private void FormatTreeView(Model.Supplier supplierformat)
        {

            if (supplierformat == null)
                return;
            int status = supplierformat.ApproveStatusId;
            GroupSupplier groupsupplierinser = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                groupsupplierinser = uow.SupplierRepository.FindGroupID(supplierformat.GroupId);
                if (groupsupplierinser != null)
                {
                    groupsupplierinser.ApproveStatusId = supplierformat.ApproveStatusId;

                    uow.SupplierRepository.Updategroupsupplier(groupsupplierinser);
                    uow.Commit();
                }
            }

            if (groupsupplierinser == null)
                return;
            if (groupsupplierinser.ApproveStatusId == ConstraintApproveStatus.ProcessStatus)
            {
                currentNode.ImageIndex = 2;
            }
            else if (groupsupplierinser.ApproveStatusId == ConstraintApproveStatus.ApproveStatus)
            {
                currentNode.BackColor = ColorTranslator.FromHtml("#38b04a");
                currentNode.ImageIndex = 0;
            }
            else if (groupsupplierinser.ApproveStatusId == ConstraintApproveStatus.CancelStatus)
            {
                currentNode.BackColor = Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(95)))), ((int)(((byte)(115)))));
                currentNode.ImageIndex = 0;
            }
            else
            {
                currentNode.ImageIndex = 2;
            }

        }
        private void SaveSupplier(Model.Supplier supplier)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (supplier.SupplierId > 0)
                {
                    uow.SupplierRepository.Update(supplier);
                }
                else
                {
                    uow.SupplierRepository.Add(supplier);
                }
                uow.Commit();
            }
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(txtsupplierCode) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_Suplier == null) return;
            CoverObjectUtility.GetAutoBindingData(this, m_Suplier);
            if (m_Subsupplier.SupplierId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Subsupplier.SetModify();
            try
            {
                SaveSupplier(m_Suplier);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                UpdateNode(m_Suplier);
                FormatTreeView(m_Suplier);
                InitializeForm(m_Suplier);
            }
            catch (Exception ex)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(txtsupplierCode) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Suplier = new Model.Supplier();
            CoverObjectUtility.GetAutoBindingData(this, m_Suplier);
            m_Suplier.ApproveStatusId = (int)ApproveStatus.Wait;
            m_Suplier.SetCreate();
            m_Suplier.SupplierId = 0;
            try
            {
                var count = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    count = uow.SupplierRepository.CheckExitSuplier(m_Suplier);
                }
                if (count > 0)
                {
                    lblNotify1.SetText(UI.CompanyisExists, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    return;
                }
                SaveSupplier(m_Suplier);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                AddNode(m_Suplier);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private SubSupplier SaveAccount(Users user)
        {
            int supplierId = string.IsNullOrWhiteSpace(txtsupplierId.Text) == false ? Convert.ToInt32(txtsupplierId.Text) : 0;
            if (supplierId <= 0)
            {
                lblNotify1.SetText(UI.deputyhasnocompany, LabelNotify.EnumStatus.Failed);
                return null;
            }
            if (ValidationUtility.IsTextAllowed(user.UserName) == false)
            {
                lblNotify1.SetText(UI.usernotallowspace, LabelNotify.EnumStatus.Failed);
                return null;
            }
            user.Sex = rdNam.Checked == true ? true : false;
            user.SetCreate();
            user.UserGroupId = (int)UserTypeFlag.Customer;
            m_Subsupplier = new SubSupplier();
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_Subsupplier);
            if (user.UserId <= 0)
                m_Subsupplier.SubSupplierId = 0;
            m_Subsupplier.SubSupplierName = user.FullName;
            m_Subsupplier.IsActive = cbActive.Checked;
            m_Subsupplier.Email = user.Email;
            m_Subsupplier.Phone = user.Phone;
            m_Subsupplier.Address = user.Address;
            m_Subsupplier.Sex = user.Sex;
            m_Subsupplier.UserId = user.UserId;
            m_Subsupplier.SupplierId = supplierId;

            IList<SubSupplier> lstExistsDeputy = gridControl1.DataSource as IList<SubSupplier>;
            SubSupplier main = lstExistsDeputy != null ? lstExistsDeputy.Where(p => p.IsMain == true && p.SubSupplierId != m_Subsupplier.SubSupplierId).FirstOrDefault() : null;
            if (main == null)
                m_Subsupplier.IsMain = true;
            else
                m_Subsupplier.IsMain = false;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (user.UserId <= 0)
                {
                    uow.UsersRepository.Add(user);
                    m_Subsupplier.SetCreate();
                    m_Subsupplier.UserId = user.UserId;
                    m_Subsupplier.SubSupplierId = 0;
                    uow.SubSupplierRepository.Add(m_Subsupplier);

                }
                else
                {
                    uow.UsersRepository.Update(user);
                    m_Subsupplier.SetModify();
                    uow.SubSupplierRepository.Update(m_Subsupplier);

                }
                uow.Commit();
            }
            return m_Subsupplier;
        }
        private void btnSaveDeputy_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(groupSubsupplier) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_User == null) return;
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_User);
            if (m_User == null) return;
            try
            {
                if (SaveAccount(m_User) == null)
                {
                    return;
                }
                if (!string.IsNullOrWhiteSpace(ptbSignature.PictureOriginPath))
                    PictureUtility.SaveImg(ptbSignature.PictureOriginPath);
                if (!string.IsNullOrWhiteSpace(ptbAvatar.PictureOriginPath))
                    PictureUtility.SaveImg(ptbAvatar.PictureOriginPath);
                gridUtility1.UpdateRow<SubSupplier>(m_Subsupplier);
                lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, LabelNotify.EnumStatus.Failed);
            }
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(groupSubsupplier) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_User == null) m_User = new Users();
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_User);
            if (string.IsNullOrWhiteSpace(m_User.Password))
            {
                m_User.Password = UtilityFunction.GetSHA256Hash(m_User.UserName);
            }
            m_User.UserId = 0;
            if (m_User == null) return;
            try
            {
                SaveAccount(m_User);
                lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
                gridUtility1.AddNewRow<SubSupplier>(m_Subsupplier);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, LabelNotify.EnumStatus.Failed);
            }
        }
        private void lnkSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbSignature);
        }

        private void lnkPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbAvatar);
        }

        private void lnkSetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_User == null) return;
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_User);
            frmSetPassword frmSetPass = new frmSetPassword(m_User);
            frmSetPass.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            if (m_User == null || m_Subsupplier == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DeputyRepository.Remove(m_Subsupplier.SubSupplierId);
                    uow.UsersRepository.Remove(m_User.UserId);
                    uow.Commit();
                }
                m_Subsupplier = new SubSupplier();
                m_User = new Users();
                InitializeForm(m_Subsupplier);
                gridView1.DeleteRow(i);
                lblNotify1.SetText(UI.removesuccess, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (m_Suplier == null) return;
            m_Suplier.ApproveStatusId = (int)ApproveStatus.Approved;
            if (m_Suplier.SupplierId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Suplier.SetModify();
            m_Suplier.ApproveBy = UserManagement.UserSession.UserName;
            m_Suplier.ApproveDate = DateTime.Now;
            try
            {
                SaveSupplier(m_Suplier);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                InitializeForm(m_Suplier);
                FormatTreeView(m_Suplier);
            }
            catch (Exception ex)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            if (m_Suplier == null) return;
            m_Suplier.ApproveStatusId = (int)ApproveStatus.Cancel;
            if (m_Suplier.SupplierId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Suplier.SetModify();
            m_Suplier.ApproveBy = UserManagement.UserSession.UserName;
            m_Suplier.ApproveDate = DateTime.Now;
            try
            {
                SaveSupplier(m_Suplier);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                InitializeForm(m_Suplier);
                FormatTreeView(m_Suplier);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }

        }

        private void linkCreateCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void SearchCompany()
        {

        }
        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            SearchCompany();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                SearchCompany();
        }

        private void AutoTextBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSaveCompany_Click_1(object sender, EventArgs e)
        {

        }

        private void lnkSetPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_User == null) return;
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_User);
            frmSetPassword frmSetPass = new frmSetPassword(m_User);
            frmSetPass.ShowDialog();
        }

        private void lnkPhoto_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbAvatar);
        }

        private void treeviewSelectRow(object sender, TreeViewEventArgs e)
        {



        }
        public void AddNode(Model.Supplier supplierAdd)
        {

            TreeNode treenode = currentNode;
            if (treenode == null)
            {
                return;
            }
            TreeTagGroupSupplier treetag = treenode.Tag as TreeTagGroupSupplier;
            TreeTagGroupSupplier tree = new TreeTagGroupSupplier
            {
                ParrentId = treetag.ParrentId,
                GroupId = treetag.GroupId
            };
            TreeNode treenodeparrent = new TreeNode();

            if( treetag.ParrentId ==0 )
            {
                tree.ParrentId = treetag.GroupId;
                treenodeparrent = treenode;
            }
            else
            {
               
             tree.ParrentId = treetag.ParrentId;
             treenodeparrent = treenode.Parent;
               
            }
            try
            {
                GroupSupplier group = new GroupSupplier
                {
                    GroupName = supplierAdd.SupplierName,
                    ParentGroup = tree.ParrentId
                };
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    group.GroupId = supplierAdd.GroupId = uow.SupplierRepository.AddGroup(group);
                    uow.SupplierRepository.Update(supplierAdd);
                    uow.Commit();
                }
                TreeNode treenodeinsert = new TreeNode();
                TreeTagGroupSupplier treetaginsert = new TreeTagGroupSupplier
                {
                    ParrentId = group.ParentGroup,
                    GroupId = group.GroupId
                };
                treenodeinsert.Tag = treetaginsert;
                treenodeinsert.Text = supplierAdd.SupplierName;
                treenodeparrent.Nodes.Add(treenodeinsert);
                treeviewsupplier.SelectedNode = treenodeinsert;
                currentNode = treeviewsupplier.SelectedNode;
                FormatTreeView(supplierAdd);
                treeviewsupplier.Refresh();
            }
            catch (Exception)
            {
                return;
            }

        }
        public void UpdateNode(Model.Supplier supplierUpdate)
        {
            TreeNode treenode = currentNode;
            treenode.Text = supplierUpdate.SupplierName;
            TreeTagGroupSupplier treetag = treenode.Tag as TreeTagGroupSupplier;
            GroupSupplier groupSupplier = new GroupSupplier
            {
                GroupId = treetag.GroupId,
                ParentGroup = treetag.ParrentId,
                GroupName = treenode.Text
            };
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.GroupSupplierRepository.Edit(groupSupplier);
                uow.Commit();
            }
            treenode.TreeView.Refresh();
        }

        private void CreateNewGroupClick(object sender, EventArgs e)
        {
            frmGroupSupplier frmgroupSupplier = new frmGroupSupplier(new RequestFrmGroupSupplier()
            {
                treeview = this.treeviewsupplier
            })
            {

            };
            frmgroupSupplier.StartPosition = FormStartPosition.CenterScreen;
            frmgroupSupplier.ShowDialog();
        }

        TreeNode nodeRight;
        private void CreateNewSupplierMenu(object sender, EventArgs e)
        {
            currentNode = nodeRight;
            m_Suplier = new Model.Supplier();
            m_Suplier = null;
            m_Subsupplier = null;
            //FormUtility.ResetForm(this);
            while (gridView1.RowCount != 0)
            {
                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();
            }
            if (m_Suplier == null)
            {
                m_Suplier = new Model.Supplier();
                InitializeForm(m_Suplier);
            }
            txtsupplierName.Focus();
        }

        private void lnkSignature_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbSignature);
        }

        private void addInformationBank(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInputBank frmInputBank = new FrmInputBank(AutoTextBox7);
            frmInputBank.StartPosition = FormStartPosition.CenterParent;
            frmInputBank.ShowDialog();
        }

        private void createnewGroupsuplier(object sender, EventArgs e)
        {
            CreateNewGroupClick(sender, e);
        }

        private void createnewsupplier(object sender, EventArgs e)
        {
            CreateNewSupplierMenu(sender, e);
        }


        private void treeviewsupplier_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                SelectDisplayNode(e.Node);
            }
            else
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.Node == null)
                    return;
                TreeTagGroupSupplier treetag = e.Node.Tag as TreeTagGroupSupplier;
               
                if (treetag.ParrentId ==0)
                {
                    menuCreateGroupsupplier.Visible = false;
                    menueditgroupsupplier.Visible = false;
                    menudeleteGroupsupplier.Visible = true;
                    deletetreenodesupplier.Visible = true;

                }
                else
                {
                    menuCreateGroupsupplier.Visible = true;
                    menueditgroupsupplier.Visible = true;
                    menudeleteGroupsupplier.Visible = false;
                    deletetreenodesupplier.Visible = true;

                }
                nodeRight = e.Node;
                contextMenuStrip1.Show(Cursor.Position);
            }
            treeviewsupplier.SelectedNode = e.Node;
            currentNode = e.Node;
        }

        private void updategroupsupplier(object sender, EventArgs e)
        {
            TreeNode treenode = treeviewsupplier.SelectedNode;
            TreeTagGroupSupplier treetag = treenode.Tag as TreeTagGroupSupplier;
            if (treenode == null || treetag.ParrentId ==0)
            {
                return;
            }
            GroupSupplier groupsupplier = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                groupsupplier = uow.SupplierRepository.FindGroupName(treenode.Text);

            }
            if (groupsupplier == null)
            {
                return;
            }
            frmEditGroupSupplier _frmeditgrouppart = new frmEditGroupSupplier(groupsupplier, treenode);
            _frmeditgrouppart.StartPosition = FormStartPosition.CenterParent;
            _frmeditgrouppart.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void linkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_User == null)
                return;
            CoverObjectUtility.GetAutoBindingData(groupSubsupplier, m_User);
            frmSetPassword frmSetPass = new frmSetPassword(m_User);
            frmSetPass.ShowDialog();
        }

        private void deletesupplier(object sender, EventArgs e)
        {
            TreeNode treenode = treeviewsupplier.SelectedNode;
            if (treenode == null)
            {
                return;
            }
            GroupSupplier groupsupplier = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                groupsupplier = uow.SupplierRepository.FindGroupName(treenode.Text);

            }
            if (groupsupplier == null)
            {
                return;
            }
            frmDeleteGroupsupplier _frmDeleteGroupsupplier = new frmDeleteGroupsupplier(groupsupplier, treenode);
            _frmDeleteGroupsupplier.StartPosition = FormStartPosition.CenterParent;
            _frmDeleteGroupsupplier.ShowDialog();
        }

        private void deletesuppliertreenode(object sender, EventArgs e)
        {

            TreeNode treenode = treeviewsupplier.SelectedNode;
            if (treenode == null)
            {
                return;
            }
            GroupSupplier groupsupplier = null;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                groupsupplier = uow.SupplierRepository.FindGroupName(treenode.Text);

            }
            if (groupsupplier == null)
            {
                return;
            }
            Model.Supplier supplier = null;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                supplier = uow.SupplierRepository.FindByGroupSupplierID(groupsupplier.GroupId);
            }


            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SupplierRepository.DeleteGroupSupplier(groupsupplier.GroupId);
                    if (supplier != null)
                        uow.SupplierRepository.Remove(supplier.SupplierId);
                    uow.Commit();

                }
                lblNotify1.SetText(UI.DeleteSuccess, LabelNotify.EnumStatus.Success, 3000);
                treeviewsupplier.Nodes.Remove(treenode);
            }
            catch (Exception exe)
            {
                lblNotify1.SetText(UI.DeleteFail, LabelNotify.EnumStatus.Failed, 3000);

            }


        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility1.SetRowColor();
            m_Subsupplier = gridUtility1.GetSelectedItem<SubSupplier>();
            if (m_Subsupplier == null)
                return;
            m_User = UtilityFunction.GetUser(m_Subsupplier);
            if (m_User == null)
                m_User = new Users();
            m_Subsupplier.User = m_User;
            InitializeForm(m_Subsupplier);
        }
    }
}

