
using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using ModernUI.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmCreateCategory : MetroForm
    {
        public frmCreateCategory()
        {
            InitializeComponent();
            Select();
            txtCode.Focus();
            txtCode.Select();
            lblNotify1.Text = string.Empty;
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;

            Model.Category cate = new Model.Category();
            CoverObjectUtility.GetAutoBindingData(this, cate);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.CategoryRepository.Add(cate);
                    uow.Commit();
                }
                TreeTag treeTag =new TreeTag();
                treeTag.NodeTye = TreeTag.Types.Category;
                treeTag.CateId = cate.CategoryId;
                treeTag.CateName = cate.CategoryName;
                TreeNode node = new TreeNode(cate.CategoryName);
                node.Tag = treeTag;
                if (AddNode != null)
                    AddNode(node);
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
