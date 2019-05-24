using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.ToolBoxCS
{
    public partial class DeputyContextMenu : ContextMenuOrigin, IGridviewContextMenu
    {
        Deputy m_DeputyOrigin;
        public DeputyContextMenu()
        {
            InitializeComponent();
            isCopied = false;
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowDelete = true;
            Init(ctxItem);
            m_DeputyOrigin = null;
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

        public void Add(object obj,int selectedrow)
        {
            m_DeputyOrigin = obj as Deputy;
            m_Selectedrow = selectedrow;
        }

        public override bool Delete()
        {
            if (m_DeputyOrigin == null) return false;
            Users user = new Users();
            user.UserId = m_DeputyOrigin.UserId;
            
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ObjectCoverRepositroy.DeleteById(m_DeputyOrigin, ColPrimaryKeyName);
                uow.UsersRepository.Remove(user.UserId);
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
