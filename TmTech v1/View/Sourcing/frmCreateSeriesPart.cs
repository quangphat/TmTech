using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmCreateSeriesPart : MetroForm
    {
        TypePart m_Sub;
        private string _nameParrentNode = string.Empty;
        public frmCreateSeriesPart(int cateId,int subId, string textParrentName)
        {
            InitializeComponent();
            m_Sub = new TypePart();
            m_Sub.TypePartID = subId;
            m_Sub.GroupPartId = cateId;
            _nameParrentNode = textParrentName;
        }

        private void frmCreateSerie_Load(object sender, EventArgs e)
        {
            //List<TypePart> lstSub;
            //using(IUnitOfWork uow = new UnitOfWork())
            //{
            //    lstSub = uow.TypePartRepository.FindByGroupID(m_Sub.GroupPartId.Value);
            //    uow.Commit();
            //}
            //Utility.ComboboxUtility.BindData<TypePart>(cbbSubCategory, lstSub, "TypePartName", "TypePartID");
            //cbbSubCategory.SelectedValue = -1;
            txtDisplayParrentName.Text = _nameParrentNode;
        }
        public delegate void delgAddNode(TreeNode node);
        public delgAddNode AddNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_Sub == null)
            {
                lblNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            SeriesPart serie = new SeriesPart();
            serie.TypePartId = m_Sub.TypePartID;
            serie.SeriesPartCode = txtCode.Text;
            serie.SeriesPartName = txtName.Text;
            serie.Note= txtNote.Text;
            try
            {
                int Id = 0;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    Id = uow.SeriesPartBaseRepository.AddandGetRequestPaymentId(serie);
                    uow.Commit();
                }
                TreeTagPart treeTag = new TreeTagPart();
                treeTag.NodeTye = TreeTagPart.Types.SeriesPart;
                treeTag.TypePartIDTag = m_Sub.TypePartID;
                treeTag.GroupPartIDTag = m_Sub.GroupPartId.Value;
                treeTag.SeriesPartIDTag = Id;
                TreeNode node = new TreeNode(serie.SeriesPartName);
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
