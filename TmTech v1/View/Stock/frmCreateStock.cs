
using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateStock : ModernUI.Forms.MetroForm
    {
        public frmCreateStock()
        {
            InitializeComponent();
        }

        private void frmCreateUnit_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            labelNotify1.Text = "";
        }

        public delegate void delgAddNewUnit(Stock stock, CRUD crud);
        public delgAddNewUnit addNewStock;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create new Unit
            Stock stock = new Stock();
            CoverObjectUtility.GetAutoBindingData(this, stock);
            stock.SetCreate();
            
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.StockRepository.Insert(stock);
                    uow.Commit();
                }
            } catch ( Exception ex)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }

            if (addNewStock != null)
                addNewStock(stock, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
