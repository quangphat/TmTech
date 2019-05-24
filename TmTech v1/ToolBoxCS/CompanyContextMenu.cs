using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public partial class CompanyContextMenu : ContextMenuOrigin,IGridviewContextMenu
    {
        Company m_CompanyOrigin;
        public CompanyContextMenu()
        {
            InitializeComponent();
            isCopied = false;
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowDelete = true;
            Init(ctxItem);
            m_CompanyOrigin = null;
        }
        public void SetGridview(GridView gridview, string primarykeyName)
        {
            m_GridView = gridview;
            ColPrimaryKeyName = primarykeyName;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public override bool Delete()
        {
            if (m_CompanyOrigin == null) return false;
            if (m_CompanyOrigin.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                FormUtility.ItemWasApproved();
                return false;
            }
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ObjectCoverRepositroy.DeleteById(m_CompanyOrigin, ColPrimaryKeyName);
                uow.Commit();
            }
            return true;
        }

        public override void Paste()
        {
            throw new NotImplementedException();
        }

        public override void Copy()
        {
            throw new NotImplementedException();
        }

        public void Add(object obj, int selectedrow)
        {
            m_CompanyOrigin = obj as Company;
            m_Selectedrow = selectedrow;
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override bool Approve()
        {
            throw new NotImplementedException();
        }
    }
}
