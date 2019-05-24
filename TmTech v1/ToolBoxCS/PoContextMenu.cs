using DevExpress.XtraGrid.Views.Grid;
using System;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.ToolBoxCS
{
    public partial class PoContextMenu : ContextMenuOrigin,IGridviewContextMenu
    {
        Po m_PoOrigin, m_CopyPO;
        public PoContextMenu()
        {
            InitializeComponent();
            isCopied = false;
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowDelete = true;
            ctxItem.ShowCopy = true;
            ctxItem.ShowPaste = true;
            ctxItem.ShowApprove = true;
            Init(ctxItem);
            m_PoOrigin = null;
            m_CopyPO = null;
        }
        public void SetGridview(GridView gridview, string primarykeyName)
        {
            m_GridView = gridview;
            ColPrimaryKeyName = primarykeyName;
        }
        public void Add(object obj,int selectedRow)
        {
            m_PoOrigin = obj as Po;
            m_Selectedrow = selectedRow;
        }

        public override bool Delete()
        {
            if (m_PoOrigin == null) return false;
            if (m_PoOrigin.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                FormUtility.ItemWasApproved();
                return false;
            }
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ObjectCoverRepositroy.DeleteById(m_PoOrigin, ColPrimaryKeyName);
                uow.Commit();
            }
            return true;
        }

        public override void Copy()
        {
            if (m_PoOrigin == null)
                return;
            m_CopyPO = new Po(m_PoOrigin);
        }

        public override void Paste()
        {
            if (m_CopyPO == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    m_CopyPO.PoCode = uow.PoRepository.GetPOCode(m_CopyPO.CompanyId, DateTime.Today);
                    if (m_CopyPO.PoId == Guid.Empty)
                    {
                        uow.PoRepository.Add(m_CopyPO);
                        //uow.PoDetailRepository.CopyPO(m_PoOrigin, m_CopyPO);
                    }
                    uow.Commit();
                    m_CopyPO.PoId = Guid.Empty;
                }
                AddNewRow<Po>( m_CopyPO);
                m_GridView.RefreshData();
            }
            catch
            {

            }
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override bool Approve()
        {
            if (m_PoOrigin == null) return false;
            if (m_PoOrigin.ApproveStatusId == (int)ApproveStatus.Approved)
                return true;
            ApproveLog log = new ApproveLog();
            log.ApproveCode = m_PoOrigin.PoCode;
            log.ApproveStatusId = (int)ApproveStatus.Approved; 
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.ObjectCoverRepositroy.Approve(m_PoOrigin, ColPrimaryKeyName,(int)ApproveStatus.Approved);
                    Debt.CreateDebt(m_PoOrigin,uow);
                    LogUtility.WriteLog(log, uow);
                    uow.Commit();
                }
                m_PoOrigin.ApproveStatusId = (int)ApproveStatus.Approved;
                UpdateRow<Po>(m_Selectedrow, m_PoOrigin);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
