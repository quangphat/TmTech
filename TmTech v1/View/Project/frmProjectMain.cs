using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TmTech_v1.View
{
    public partial class frmProjectMain : UserControl
    {
        GridUtility utility;
        
        public frmProjectMain()
        {
            InitializeComponent();
            utility = new GridUtility(gridControl1);
            utility.FormatDisplay();
        }

        private void frmProjectMain_Load(object sender, EventArgs e)
        {
            IList<Project> lstPro = new List<Project>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstPro = uow.ProjectBaseRepository.All();
                uow.Commit();
            }

            utility.BindingData(lstPro);
            dtpDateBegin.EditValue = dtpDateEnd.EditValue = DateTime.Now;
        }

        private void InsertOrUpdate(Project pro, CRUD cru)
        {
            if (cru == CRUD.Insert)
                utility.AddNewRow( pro);
            else
                utility.UpdateRow( pro);
            gridView1.RefreshData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProject obj = new frmCreateProject();
            obj.insert = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView grid = sender as GridView;
            GridHitInfo hi = grid.CalcHitInfo(grid.GridControl.PointToClient(MousePosition));
            if (hi.InRow || hi.InRowCell)
            {
                Project pro = utility.GetSelectedItem<Project>();
                if (pro == null)
                    return;
                frmEditProject obj = new frmEditProject(pro);
                obj.update = InsertOrUpdate;
                obj.ShowDialog();
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult result = FormUtility.MsgDelete();
                if(result == DialogResult.Yes)
                {
                    int i = gridView1.GetSelectedRows()[0];
                    Project pro = utility.GetSelectedItem<Project>();
                    if (pro == null)
                        return;
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.ProjectBaseRepository.Remove(pro);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                e.Handled = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            IList<Project> lst = new List<Project>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lst = uow.ProjectBaseRepository.Find((DateTime)dtpDateBegin.EditValue, (DateTime)dtpDateEnd.EditValue);
                uow.Commit();
            }
            utility.BindingData(lst);
        }
    }
}
