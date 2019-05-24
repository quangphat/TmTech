using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmCurrencyUnit : UserControl
    {
        GridUtility utility;
        
        public frmCurrencyUnit()
        {
            InitializeComponent();
        }

        private void InsertOrUpdate(Model.CurrencyUnit cu, Utility.CRUD cru)
        {
            if (cru == Utility.CRUD.Insert)
            {
                utility.AddNewRow(cu);
            }
            else
            {
                utility.UpdateRow(cu);
            }
            gridView4.RefreshData();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCurrencyUnit obj = new frmCreateCurrencyUnit();
            obj.insertCurrency = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void frmCurrencyUnit_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            utility = new GridUtility(gridControl1);
            IList<CurrencyUnit> lstCU = new List<CurrencyUnit>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstCU = uow.CurrencyUnitRepository.All();
                    uow.Commit();
                }
                utility.BindingData(lstCU);
            }
            catch { }
            
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            GridHitInfo info = gridView.CalcHitInfo(gridView.GridControl.PointToClient(MousePosition));
            if(info.InRow || info.InRowCell)
            {
                CurrencyUnit unit = utility.GetSelectedItem<CurrencyUnit>();
                frmEditCurrencyUnit obj = new frmEditCurrencyUnit(unit);
                obj.updateCurrencyUnit = InsertOrUpdate;
                obj.ShowDialog();
            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            utility.DrawAll(e);
        }

        private void gridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult result = FormUtility.MsgDelete();
                CurrencyUnit unit = utility.GetSelectedItem<CurrencyUnit>();
                int index = gridView4.GetSelectedRows()[0];
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.CurrencyUnitRepository.Remove(unit);
                            uow.Commit();
                        }
                        gridView4.DeleteRow(index);
                        labelNotify1.SetText(UI.removesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                    }
                    catch
                    {
                        labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }
    }
}
