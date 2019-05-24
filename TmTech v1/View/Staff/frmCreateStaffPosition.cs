using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateStaffPosition : ModernUI.Forms.MetroForm
    {
        public delegate void delgInsert(StaffPosition staffPosition, CRUD crud);
        public delgInsert insert;
        public frmCreateStaffPosition()
        {
            InitializeComponent();
        }

        private void frmCreateStaffPosition_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            AcceptButton = btnSave;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffPosition staffPosition = new StaffPosition();
            CoverObjectUtility.GetAutoBindingData(this, staffPosition);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.StaffPositionRepository.Add(staffPosition);
                    uow.Commit();
                }
                if (insert != null)
                    insert(staffPosition, CRUD.Insert);
                Close();
            }
            catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
