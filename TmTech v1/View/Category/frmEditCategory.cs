
using System;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using ModernUI.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmEditCategory : MetroForm
    {
        Category m_Category;
        public frmEditCategory(Category category)
        {
            InitializeComponent();
            lblNotify1.Text = "";
            Select();
            m_Category = category;
            txtCode.Select();
            txtCode.Focus();
        }

        private void InitializeForm(Category category)
        {
            CoverObjectUtility.SetAutoBindingData(this, category);
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            InitializeForm(m_Category);
        }


        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            CoverObjectUtility.GetAutoBindingData(this, m_Category);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    if (uow.CategoryRepository.FindExist(m_Category) == true)
                    {
                        lblNotify1.SetText(UI.codehasexist, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                        return;
                    }
                    else
                    {
                        uow.CategoryRepository.Update(m_Category);
                        TreeNode node = new TreeNode(m_Category.CategoryName);
                        node.Name = m_Category.CategoryName;
                        node.Text = m_Category.CategoryName;
                        TreeTag tag = new TreeTag();
                        tag.NodeTye = TreeTag.Types.Category;
                        tag.CateId = m_Category.CategoryId;
                        tag.CateName = m_Category.CategoryName;
                        node.Tag = tag;
                        if (UpdateNode != null)
                            UpdateNode(node);
                        lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
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
