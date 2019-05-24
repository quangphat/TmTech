using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditTypePart : MetroForm
    {
        TypePart m_SubCate;

        public frmEditTypePart(TypePart sub , string NameParrent)
        {
            InitializeComponent();
            m_SubCate = sub;

            txtParrentName.Text = NameParrent;
        }
        private void frmEditSub_Load(object sender, EventArgs e)
        {
       
            txtCode.Text = m_SubCate.TypePartCode;
            txtName.Text = m_SubCate.TypePartName;
            txtNote.Text = m_SubCate.Note;
        }
        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            m_SubCate.TypePartCode = txtCode.Text;
            m_SubCate.TypePartName = txtName.Text;
            m_SubCate.Note = txtNote.Text;
            try
            {
                int Id = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.TypePartBaseRepository.Update(m_SubCate);
                    uow.Commit();
                }
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.TypePart;
                treeTag.GroupPartIDTag = m_SubCate.GroupPartId!=null ? (int)m_SubCate.GroupPartId:0;
                treeTag.TypePartIDTag = Id;
                TreeNode node = new TreeNode(m_SubCate.TypePartName);
                node.Text = m_SubCate.TypePartName;
                node.Name = m_SubCate.TypePartName;
            
                if (UpdateNode != null)
                    UpdateNode(node);
                lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                Close();
            }
            catch
            {
                lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }
    }
}
