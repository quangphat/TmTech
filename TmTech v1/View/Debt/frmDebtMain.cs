using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using DevExpress.XtraGrid.Views.Grid;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.View
{
    public partial class frmDebtMain : UserControl, IHandlerEventDatagridview
    {
        GridUtility gridUtility;
        public frmDebtMain()
        {
            InitializeComponent();
            //FormUtility.FormatDatetimeCtrl(this);
            IGridviewContextMenu ctxMenu = new DebtContextMenu(gridControl1);
            gridUtility = new GridUtility(gridControl1, ctxMenu);
            txtSearch.Select();
        }

        public void HandlerEventDoubleClick(object T)
        {
            throw new NotImplementedException();
        }

        public void HandlerEventRowSelect(object T)
        {
            throw new NotImplementedException();
        }

        private void frmDebtMain_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }


        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Return)
                Search();
        }
        private void LoadGrid()
        {
            IList<Debt> lstDebt;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDebt = uow.DebtRepository.Search("");
                uow.Commit();
            }
            gridUtility.BindingData(lstDebt);
        }
        private void Search()
        {
            IList<Debt> lstDebt;
            //if (string.IsNullOrWhiteSpace(txtSearch.Text)) return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDebt = uow.DebtRepository.Search(txtSearch.Text);
                uow.Commit();
            }
            gridUtility.BindingData( lstDebt);
        }


        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
            Debt debt = gridUtility.GetSelectedItem<Debt>();
            txtCompanyDebt.Text = CurrencyUtility.DecimalToString(debt.RestValuePerCompany);
        }
        private void AddOrUpdate(Debt debt,CRUD flag)
        {
            if(flag== CRUD.Update)
            {
                gridUtility.UpdateRow<Debt>(debt);
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            Debt debt = gridView1.GetRow(i) as Debt;
            if (debt == null) return;
            frmCreateDebt frmCreate = new frmCreateDebt(debt);
            frmCreate.UpdateRow = AddOrUpdate;
            frmCreate.ShowDialog();
        }
    }
}
