using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditStock : ModernUI.Forms.MetroForm
    {
        Stock m_stock;

        public frmEditStock(Stock stock)
        {
            InitializeComponent();
            m_stock = stock;
            AcceptButton = btnSave;
        }

        private void frmEditStock_Load(object sender, EventArgs e)
        {
            if (m_stock != null)
            {
                CoverObjectUtility.SetAutoBindingData(this, m_stock);
                labelNotify1.Text = "";
            }
        }

        public delegate void delgUpdateNewStock(Stock stock, CRUD crud);
        public delgUpdateNewStock UpdateNewstock;

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, m_stock);
            m_stock.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.StockRepository.Edit(m_stock);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            if (UpdateNewstock != null)
                UpdateNewstock(m_stock, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
