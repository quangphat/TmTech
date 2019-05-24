using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmUnitMain : UserControl
    {
        GridUtility gridUtility;
        
        public frmUnitMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmUnitMain_Load(object sender, EventArgs e)
        {
            loadUnitDB();
            labelNotify1.Text = "";
        }

        private void loadUnitDB()
        {
            IList<Unit> lstUnit = new List<Unit>();
            using (IUnitOfWork uow = new UnitOfWork())
            {

                lstUnit = uow.UnitRepository.All();
                uow.Commit();
            }
            gridUtility.BindingData( lstUnit);

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateUnit fU = new frmCreateUnit();
            fU.addnewunit = AddOrUpdate;
            fU.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void AddOrUpdate(Unit unit,CRUD crud)
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
            Unit unit = gridUtility.GetSelectedItem<Unit>();
            if (unit == null) return;
            frmEditUnit fEU = new frmEditUnit(unit);
            fEU.UpdateNewUnit = AddOrUpdate;
            fEU.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Unit unit = gridUtility.GetSelectedItem<Unit>();
            if (unit == null) return;
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.UnitRepository.Remove(unit);
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
