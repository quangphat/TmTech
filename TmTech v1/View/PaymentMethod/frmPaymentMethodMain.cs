using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmPaymentMethodMain : UserControl
    {
        GridUtility gridUtility;
        
        public frmPaymentMethodMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }


        private void InsertOrUpdate(PaymentMethod pm, CRUD cru)
        {
            if (cru == CRUD.Insert)
                gridUtility.AddNewRow( pm);
            else
                gridUtility.UpdateRow( pm);
            gridView1.RefreshData();
        }

        private void frmPaymentMethodMain_Load(object sender, EventArgs e)
        {
            IList<PaymentMethod> lstPm = new List<PaymentMethod>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPm = uow.PaymentMethodRepository.All();
                uow.Commit();
            }
            gridUtility.BindingData( lstPm);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreatePaymentMethod obj = new frmCreatePaymentMethod();
            obj.insert = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView grid = sender as GridView;
            GridHitInfo hi = grid.CalcHitInfo(grid.GridControl.PointToClient(MousePosition));
            if (hi.InRow || hi.InRowCell)
            {
                PaymentMethod pm = gridUtility.GetSelectedItem<PaymentMethod>();
                if (pm == null)
                    return;
                frmEditPaymentMethod obj = new frmEditPaymentMethod(pm);
                obj.update = InsertOrUpdate;
                obj.ShowDialog();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult rs = FormUtility.MsgDelete();
                if(rs == DialogResult.Yes)
                {
                    int i = gridView1.GetSelectedRows()[0];
                    PaymentMethod pm = gridUtility.GetSelectedItem<PaymentMethod>();
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.PaymentMethodRepository.Remove(pm);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                e.Handled = true;
            }
        }
    }
}
