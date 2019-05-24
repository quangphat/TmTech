using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditLocation : ModernUI.Forms.MetroForm
    {
        Location m_Location;

        public frmEditLocation(Location Location)
        {
            InitializeComponent();
            m_Location = Location;
            AcceptButton = btnSave;
        }

        private void frmEditLocation_Load(object sender, EventArgs e)
        {
            if (m_Location != null)
            {
                CoverObjectUtility.SetAutoBindingData(this, m_Location);
                labelNotify1.Text = "";
            }
        }

        public delegate void delgUpdateNewLocation(Location Location, CRUD crud);
        public delgUpdateNewLocation UpdateNewLocation;

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, m_Location);
            m_Location.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.LocationRepository.Edit(m_Location);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            if (UpdateNewLocation != null)
                UpdateNewLocation(m_Location, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
