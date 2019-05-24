using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class DebtContextMenu : ContextMenuOrigin,IGridviewContextMenu
    {
        private View.frmCreateDebt m_frmCreate;
        private Model.Debt m_Debt;
        public DebtContextMenu(GridControl gridcontrol )
        {
            InitializeComponent();
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowEdit = true;
            Init(ctxItem);
            m_Debt = null;
        }
        public DebtContextMenu(GridControl gridcontrol ,View.frmCreateDebt frmCreate)
        {
            InitializeComponent();
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowEdit = true;
            Init(ctxItem);
            m_frmCreate = frmCreate;
            m_Debt = null;
        }
        public void SetGridview(GridView gridview, string primarykeyName)
        {
            m_GridView = gridview;
            ColPrimaryKeyName = primarykeyName;
        }
        public override void Edit()
        {
            if (m_Debt == null) return;
            m_frmCreate = new View.frmCreateDebt(m_Debt);
            m_frmCreate.ShowDialog();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override void Paste()
        {
            throw new NotImplementedException();
        }

        public override void Copy()
        {
            throw new NotImplementedException();
        }

        public void Add(object obj,int selectedrow)
        {
            m_Debt = obj as Model.Debt;
            m_Selectedrow = selectedrow;
        }

        public override bool Approve()
        {
            throw new NotImplementedException();
        }
    }
}
