using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmStockMain : UserControl
    {
        GridUtility gridUtility;
        
        public frmStockMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmStockMain_Load(object sender, EventArgs e)
        {
            loadStockDB();
            labelNotify1.Text = "";
        }

        private void loadStockDB()
        {
            IList<Stock> lstStock = new List<Stock>();
            using (IUnitOfWork uow = new UnitOfWork())
            {

                lstStock = uow.StockRepository.GetAll();
                uow.Commit();
            }
            gridUtility.BindingData( lstStock);

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateStock fU = new frmCreateStock();
            fU.addNewStock = AddOrUpdate;
            fU.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void AddOrUpdate(Stock unit,CRUD crud)
        {
            if(crud== CRUD.Insert)
            {
                gridUtility.AddNewRow(unit);
            }
            if (crud == CRUD.Update)
            {
                gridUtility.UpdateRow( unit);
            }
            gridControl1.RefreshDataSource();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Stock unit = gridUtility.GetSelectedItem<Stock>();
            if (unit == null) return;
            frmEditStock fEU = new frmEditStock(unit);
            fEU.UpdateNewstock = AddOrUpdate;
            fEU.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Stock stock = gridUtility.GetSelectedItem<Stock>();
            if (stock == null) return;
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.StockRepository.Delete(stock);
                        uow.Commit();
                    }
                }
                catch
                {
                    labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    return;
                }
                gridView1.DeleteRow(i);
            }
        }
    }
}
