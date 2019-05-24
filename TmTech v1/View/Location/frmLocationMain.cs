using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmLocationMain : UserControl
    {
        GridUtility gridUtility;

        public frmLocationMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmLocationMain_Load(object sender, EventArgs e)
        {
            loadLocationDB();
            labelNotify1.Text = "";
        }

        private void loadLocationDB()
        {
            IList<Location> lstLocation = new List<Location>();
            using (IUnitOfWork uow = new UnitOfWork())
            {

                lstLocation = uow.LocationRepository.GetAll();
                uow.Commit();
            }
            gridUtility.BindingData( lstLocation);

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateLocation fU = new frmCreateLocation();
            fU.addNewLocation = AddOrUpdate;
            fU.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void AddOrUpdate(Location unit,CRUD crud)
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
            Location unit = gridUtility.GetSelectedItem<Location>();
            if (unit == null) return;
            frmEditLocation fEU = new frmEditLocation(unit);
            fEU.UpdateNewLocation = AddOrUpdate;
            fEU.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Location Location = gridUtility.GetSelectedItem<Location>();
            if (Location == null) return;
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.LocationRepository.Delete(Location);
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
