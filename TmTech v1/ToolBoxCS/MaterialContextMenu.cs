using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using TmTech_v1.Interface;

namespace TmTech_v1.ToolBoxCS
{
    public partial class MaterialContextMenu : ContextMenuOrigin, IGridviewContextMenu
    {
        Model.Material m_MaterialOrigin;
        public MaterialContextMenu()
        {
            InitializeComponent();
            isCopied = false;
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowDelete = true;
            Init(ctxItem);
            m_MaterialOrigin = null;
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
            m_MaterialOrigin = obj as Model.Material;
            m_Selectedrow = selectedrow;
        }

        public override bool Delete()
        {
            if (m_MaterialOrigin == null) return false;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ObjectCoverRepositroy.DeleteById(m_MaterialOrigin, ColPrimaryKeyName);
                uow.Commit();
            }
            return true;
        }

        public override void Paste()
        {
            throw new System.NotImplementedException();
        }

        public override void Copy()
        {
            throw new System.NotImplementedException();
        }

        public override void Edit()
        {
            throw new System.NotImplementedException();
        }

        public override bool Approve()
        {
            throw new System.NotImplementedException();
        }
    }
}
