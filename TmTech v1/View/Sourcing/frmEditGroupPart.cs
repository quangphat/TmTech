
using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmEditGroupPart : MetroForm
    {
        GroupPart m_GroupPart;
        public frmEditGroupPart(GroupPart groupPart)
        {
            InitializeComponent();
            lblNotify1.Text = "";
            Select();
            m_GroupPart = groupPart;
            txtCode.Select();
            txtCode.Focus();
        }

        private void InitializeForm(GroupPart groupPart)
        {
            txtCode.Text = groupPart.GroupPartCode;
            txtName.Text = groupPart.GroupPartName;
            txtNote.Text= groupPart.Note;
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            InitializeForm(m_GroupPart);
        }

        private void cbbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            m_GroupPart.GroupPartName = txtName.Text;
            m_GroupPart.GroupPartCode = txtCode.Text;
            m_GroupPart.Note = txtNote.Text;
            m_GroupPart.ModifyDate = DateTime.Now;
            m_GroupPart.ModifyBy = UserManagement.UserSession.UserName;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    if (uow.GroupPartBaseRepository.FindExist(m_GroupPart) == true)
                    {
                        lblNotify1.SetText(UI.codehasexist, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                        return;
                    }
                    else
                    {
                        uow.GroupPartBaseRepository.Update(m_GroupPart);
                        TreeNode node = new TreeNode(m_GroupPart.GroupPartName);
                        node.Name = m_GroupPart.GroupPartName;
                        node.Text = m_GroupPart.GroupPartName;
                        TreeTagPart tag = new TreeTagPart();
                        tag.NodeTye = TreeTagPart.Types.GroupPart;
                        tag.GroupPartIDTag = m_GroupPart.GroupPartId;
                        node.Tag = tag;
                        if (UpdateNode != null)
                            UpdateNode(node);
                        lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                        Close();
                    }
                    uow.Commit();
                }
                return;
            }
            catch
            {
                lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }

        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
