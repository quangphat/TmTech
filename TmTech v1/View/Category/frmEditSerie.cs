using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditSerie : MetroForm
    {
        Series m_Serie;
        TreeTag m_Tag;
        public frmEditSerie(Series serie,TreeTag treeTag)
        {
            InitializeComponent();
            m_Serie = serie;
            lblNotify1.Text = string.Empty;
            m_Tag = treeTag;
        }

        private void frmEditSerie_Load(object sender, EventArgs e)
        {
            productPath1.Show(m_Tag.CateName, "", "");
            CoverObjectUtility.SetAutoBindingData(this,m_Serie);
        }
        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            CoverObjectUtility.GetAutoBindingData(this, m_Serie);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SeriesRepository.Update(m_Serie);
                    uow.Commit();
                }
                TreeNode node = new TreeNode(m_Serie.SerieName);
                node.Name = m_Serie.SerieName;
                node.Text = m_Serie.SerieName;
                TreeTag tag = new TreeTag();
                tag.NodeTye = TreeTag.Types.Serie;
                tag.CateId = m_Serie.CategoryId;
                tag.CateName = m_Tag.CateName;
                tag.SerieId = m_Serie.SerieId;
                tag.SerieName = m_Serie.SerieName;
                node.Tag = tag;
                if (UpdateNode != null)
                    UpdateNode(node);
                lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }
    }

}
