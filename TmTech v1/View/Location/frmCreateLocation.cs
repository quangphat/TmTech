
using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateLocation : ModernUI.Forms.MetroForm
    {
        public frmCreateLocation()
        {
            InitializeComponent();
        }

        private void frmCreateUnit_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            labelNotify1.Text = "";
        }

        public delegate void delgAddNewUnit(Location Location, CRUD crud);
        public delgAddNewUnit addNewLocation;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create new Unit
            Location Location = new Location();
            CoverObjectUtility.GetAutoBindingData(this, Location);
            Location.SetCreate();
            
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.LocationRepository.Insert(Location);
                    uow.Commit();
                }
            } catch ( Exception ex)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }

            if (addNewLocation != null)
                addNewLocation(Location, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
