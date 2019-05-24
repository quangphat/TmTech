
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;
using ModernUI.Forms;
using TmTech_v1.Interface;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmCreateGroupPart : MetroForm
    {
        List<Model.GroupPart> lstCategory;
        public frmCreateGroupPart()
        {
            InitializeComponent();
            Select();
            txtCode.Focus();
            txtCode.Select();
            lblNotify1.Text = string.Empty;
            lstCategory = new List<Model.GroupPart>();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
        }
        
        public delegate void delgSetFormEnable(bool isEnable);
        private void frmCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cbbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;

            Model.GroupPart cate = new Model.GroupPart();
            cate.GroupPartName = txtName.Text;
            cate.GroupPartCode = txtCode.Text; 
            cate.Note = txtNote.Text;
            cate.CreateBy = UserManagement.UserSession.UserName;
            cate.CreateDate = DateTime.Now;
            cate.ModifyDate = DateTime.Now;
            cate.ModifyBy = UserManagement.UserSession.UserName;
            try
            {
                int Id = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    Id =uow.GroupPartBaseRepository.AddandGetRequestPaymentId(cate);
                    uow.Commit();
                }
                TreeTagPart treeTag =new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.GroupPart;
                treeTag.GroupPartIDTag = Id;
                TreeNode node = new TreeNode(cate.GroupPartName);
                node.Tag = treeTag;
                if (AddNode != null)
                    AddNode(node);

                lblNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                Close();
            
            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
