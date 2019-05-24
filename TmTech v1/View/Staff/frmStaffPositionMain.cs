using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmStaffPositionMain : UserControl
    {
        public GridUtility utility;
        
        public frmStaffPositionMain()
        {
            InitializeComponent();
        }

        private void frmStaffPositionMain_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            utility = new GridUtility(gridControl1);
            IList<StaffPosition> lstSP = new List<StaffPosition>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstSP = uow.StaffPositionRepository.All();
                    uow.Commit();
                }
            }
            catch { }
            utility.BindingData(lstSP);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateStaffPosition obj = new frmCreateStaffPosition();
            obj.insert = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            utility.DrawAll(e);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            GridHitInfo hitInfo = gridView1.CalcHitInfo(gridView1.GridControl.PointToClient(MousePosition));
            if(hitInfo.InRow||hitInfo.InRowCell)
            {
                StaffPosition staffPosition = utility.GetSelectedItem<StaffPosition>();
                if (staffPosition == null)
                    return;
                frmEditStaffPosition obj = new frmEditStaffPosition(staffPosition);
                obj.update = InsertOrUpdate;
                obj.ShowDialog();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            StaffPosition staffPosition = utility.GetSelectedItem<StaffPosition>();
            if (staffPosition == null)
                return;
            DialogResult result = FormUtility.MsgDelete();
            if(result== DialogResult.Yes)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.StaffPositionRepository.Remove(staffPosition);
                        uow.Commit();
                    }
                    labelNotify1.SetText(UI.removesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                    gridView1.DeleteSelectedRows();
                }
                catch
                {
                    labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                }
            }
        }

        private void InsertOrUpdate(StaffPosition staffPosition, CRUD crud)
        {
            if (crud == CRUD.Insert)
                utility.AddNewRow(staffPosition);
            else
                utility.UpdateRow(staffPosition);
            gridView1.RefreshData();
        }
    }
}
