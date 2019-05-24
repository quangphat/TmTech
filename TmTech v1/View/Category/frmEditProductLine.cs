using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditProductLine : MetroForm
    {
        ProductLine m_Line;
        TreeTag m_Tag;
        public frmEditProductLine(ProductLine line,TreeTag treeTag)
        {
            InitializeComponent();
            m_Line = line;
            m_Tag = treeTag;
        }

        private void frmEditSub_Load(object sender, EventArgs e)
        {
            CoverObjectUtility.SetAutoBindingData(this, m_Line);
            productPath1.Show(m_Tag.CateName, m_Tag.SerieName, "");
        }
        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            CoverObjectUtility.GetAutoBindingData(this, m_Line);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ProductLineRepository.Update(m_Line);
                    TreeNode node = new TreeNode(m_Line.ProductLineName);
                    node.Name = m_Line.ProductLineName;
                    node.Text = m_Line.ProductLineName;
                    TreeTag tag = new TreeTag();
                    tag.NodeTye = TreeTag.Types.Line;
                    tag.CateId = m_Tag.CateId;
                    tag.CateName = m_Tag.CateName;
                    tag.SerieName = m_Tag.SerieName;
                    tag.SerieId = m_Tag.SerieId;
                    tag.LineId = m_Line.ProductLineId;
                    tag.LineName = m_Line.ProductLineName;
                    node.Tag = tag;
                    if (UpdateNode != null)
                        UpdateNode(node);
                    lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);

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
    }
}
