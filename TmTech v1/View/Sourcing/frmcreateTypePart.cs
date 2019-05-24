using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmcreateTypePart : MetroForm
    {
        GroupPart m_Category;
        string _currentTextNode = string.Empty;
        public frmcreateTypePart(int cateId,string   strTextTag)
        {
            InitializeComponent();
            m_Category =new GroupPart();
            m_Category.GroupPartId = cateId;
            _currentTextNode = strTextTag;
        }

        private void frmCreateSub_Load(object sender, EventArgs e)
        {
            txtNameParrent.Text = _currentTextNode;
            txtNameParrent.ReadOnly = true;
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(m_Category==null)
            {
                lblNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            TypePart sub = new TypePart();
            sub.GroupPartId = m_Category.GroupPartId;
            sub.TypePartCode = txtCode.Text;
            sub.TypePartName = txtName.Text;
            sub.Note = txtNote.Text;
            try
            {
                int Id = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    Id = uow.TypePartBaseRepository.AddandGetRequestPaymentId(sub);
                    uow.Commit();
                }
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.TypePart;
                treeTag.GroupPartIDTag = m_Category.GroupPartId;
                treeTag.TypePartIDTag = Id;
                TreeNode node = new TreeNode(sub.TypePartName);
                node.Tag = treeTag;
                if (AddNode != null)
                    AddNode(node);
                lblNotify1.SetText(UI.createsuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                Close();

            }
            catch
            {
                
            }
        }

        private void cbbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
