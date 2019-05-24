using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmCreateSerie : MetroForm
    {
        TreeTag m_tag;
        Category m_Cate;
        public frmCreateSerie(TreeTag tag)
        {
            InitializeComponent();
            lblNotify1.Text = "";
            m_tag = tag;
        }

        private void frmCreateSerie_Load(object sender, EventArgs e)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                m_Cate = uow.CategoryRepository.Find(m_tag.CateId);
                uow.Commit();
            }
            if (m_Cate != null)
            {
                productPath1.Show(m_Cate.CategoryName, "", "");
            }
            //ComboboxUtility.BindCategory(cbbCategory,m_tag.CateId);
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            Series serie = new Series();
            if (ValidationUtility.FieldNotAllowNull(this) == false) return;
            CoverObjectUtility.GetAutoBindingData(this, serie);
            serie.CategoryId = m_Cate.CategoryId;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.SeriesRepository.Add(serie);
                uow.Commit();
               
            }
            TreeTag newTag = new TreeTag();
            newTag.CateId = m_Cate.CategoryId;
            newTag.CateName = m_Cate.CategoryName;
            newTag.SerieId = serie.SerieId;
            newTag.SerieName = serie.SerieName;
            newTag.NodeTye = TreeTag.Types.Serie;
            TreeNode node = new TreeNode(serie.SerieName);
            node.Tag = newTag;
            if (AddNode != null)
                AddNode(node);
            this.Close();
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
