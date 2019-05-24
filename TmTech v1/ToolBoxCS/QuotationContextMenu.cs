
using DevExpress.XtraGrid.Views.Grid;
using System;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.ToolBoxCS
{

    public partial class QuotationContextMenu : ContextMenuOrigin, IGridviewContextMenu
    {
        Quotation m_QutationOrigin;
        Quotation m_CopyQuotation;
        
        public QuotationContextMenu()
        {
            InitializeComponent();
            isCopied = false;
            ContextItem ctxItem = new ContextItem();
            ctxItem.ShowDelete = true;
            ctxItem.ShowCopy = true;
            ctxItem.ShowPaste = true;
            Init(ctxItem);
            m_QutationOrigin = null;
            m_CopyQuotation = null;
        }
        public void Add(object obj,int selectedRow)
        {
            m_QutationOrigin = obj as Quotation;
            m_Selectedrow = selectedRow;
        }

        public override bool Delete()
        {
            if (m_QutationOrigin == null) return false;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ObjectCoverRepositroy.DeleteById(m_QutationOrigin, ColPrimaryKeyName);
                uow.Commit();
            }
            return true;
        }



        public override void Copy()
        {
            if (m_QutationOrigin == null)
                return;
            m_CopyQuotation = new Quotation(m_QutationOrigin);
        }



        public override void Paste()
        {
            if (m_CopyQuotation == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    m_CopyQuotation.QuotationCode = uow.QuotationRepository.GetQuotationCode(m_CopyQuotation.CusId, DateTime.Today);
                    if (m_CopyQuotation.QuotationId == Guid.Empty)
                    {
                        uow.QuotationRepository.Add(m_CopyQuotation);
                        uow.QuotationDetailRepository.CopyQuotation(m_QutationOrigin, m_CopyQuotation);
                    }
                    uow.Commit();
                    m_CopyQuotation.QuotationId = Guid.Empty;
                }
                AddNewRow<Quotation>(m_CopyQuotation);
            }
            catch (Exception)
            {

            }
        }


        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public void SetGridview(GridView gridview, string primarykeyName)
        {
            m_GridView = gridview;
            ColPrimaryKeyName = primarykeyName;
        }

        public override bool Approve()
        {
            throw new NotImplementedException();
        }
    }
}
