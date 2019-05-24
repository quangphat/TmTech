using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditStaffPosition : ModernUI.Forms.MetroForm
    {
        public StaffPosition staffPosition;
        public delegate void delgUpdate(StaffPosition staffPosition, CRUD crud);
        public delgUpdate update;
        public frmEditStaffPosition(StaffPosition staffPosition)
        {
            InitializeComponent();
            this.staffPosition = staffPosition;
        }

        private void frmEditStaffPosition_Load(object sender, EventArgs e)
        {
            if (staffPosition == null)
                return;
            CoverObjectUtility.SetAutoBindingData(this, staffPosition);
            labelNotify1.Text = "";
            AcceptButton = btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            CoverObjectUtility.GetAutoBindingData(this, staffPosition);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.StaffPositionRepository.Update(staffPosition);
                    uow.Commit();
                }
                if (update != null)
                    update(staffPosition, CRUD.Update);
                Close();
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
