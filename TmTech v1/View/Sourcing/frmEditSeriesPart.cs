using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmEditSeriesPart : MetroForm
    {
        SeriesPart m_Serie;
        int m_cateId;
        public frmEditSeriesPart(SeriesPart serie,int cateId,string parrentNodeName)
        {
            InitializeComponent();
            m_Serie = serie;
            lblNotify1.Text = string.Empty;
            m_cateId = cateId;
            txtParrentName.Text = parrentNodeName;
        }

        private void frmEditSerie_Load(object sender, EventArgs e)
        {
            List<TypePart> lstSub;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSub = uow.TypePartBaseRepository.FindByGroupID(m_cateId);
                uow.Commit();
            }
           
            InitializeForm(m_Serie);
        }
        private void InitializeForm(SeriesPart serie)
        {
           
            txtName.Text = serie.SeriesPartName;
            txtNote.Text = serie.Note;
            txtCode.Text = serie.SeriesPartCode;
        }
        public delegate void delgUpdateNode(TreeNode node);
        public delgUpdateNode UpdateNode;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
           
            m_Serie.SeriesPartName = txtName.Text;
            m_Serie.SeriesPartCode = txtCode.Text;
            m_Serie.Note = txtNote.Text;
            m_Serie.ModifyBy = UserManagement.UserSession.UserName;
            m_Serie.ModifyDate = DateTime.Now;
            try
            {
                using(IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SeriesPartBaseRepository.Update(m_Serie);
                    uow.Commit();
                }
                TreeNode node = new TreeNode(m_Serie.SeriesPartName);
                node.Name = m_Serie.SeriesPartName;
                node.Text = m_Serie.SeriesPartName;
                TreeTagPart tag = new TreeTagPart();
                tag.NodeTye = TreeTagPart.Types.SeriesPart;
                tag.TypePartIDTag = m_Serie.TypePartId.Value;
              
                if (UpdateNode != null)
                    UpdateNode(node);
                lblNotify1.SetText(UI.updatesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                Close();
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
    }

}
