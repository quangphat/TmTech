using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmCreateSub : MetroForm
    {
        Category m_Category;
        Series m_Serie;
        TreeTag m_Tag;
        public frmCreateSub(TreeTag tag)
        {
            InitializeComponent();
            m_Category = null;
            m_Serie = null;
            m_Tag = tag;
            lblNotify1.Text = "";
        }

        private void frmCreateSub_Load(object sender, EventArgs e)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Category = uow.CategoryRepository.Find(m_Tag.CateId);
                m_Serie = uow.SeriesRepository.Find(m_Tag.SerieId);
                uow.Commit();
            }
            if (m_Category != null && m_Serie != null)
            {
                productPath1.Show(m_Category.CategoryName, m_Serie.SerieName, "");
            }
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            ProductLine line = new ProductLine();
            line.SerieId = m_Serie.SerieId;
            CoverObjectUtility.GetAutoBindingData(this, line);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ProductLineRepository.Add(line);
                    uow.Commit();
                }
                TreeTag tag = new TreeTag();

                tag.CateId = m_Category.CategoryId;
                tag.CateName = m_Category.CategoryName;
                tag.SerieId = m_Serie.SerieId;
                tag.SerieName = m_Serie.SerieName;
                tag.LineId = line.ProductLineId;
                tag.LineName = line.ProductLineName;
                tag.NodeTye = TreeTag.Types.Line;
                TreeNode node = new TreeNode(line.ProductLineName);
                node.Tag = tag;
                if (AddNode != null)
                    AddNode(node);
                this.Close();
            }
            catch
            {
            }
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
