using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateUnit : ModernUI.Forms.MetroForm
    {
        public frmCreateUnit()
        {
            InitializeComponent();
        }

        private void frmCreateUnit_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            labelNotify1.Text = "";
        }

        public delegate void delgAddNewUnit(Unit unit, CRUD crud);
        public delgAddNewUnit addnewunit;

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create new Unit
            Unit unit = new Unit();
            CoverObjectUtility.GetAutoBindingData(this, unit);
            unit.SetCreate();
            
            //ModifyDate and ModifyBy is set null
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UnitRepository.Add(unit);
                    uow.Commit();
                }
            } catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }

            if (addnewunit != null)
                addnewunit(unit, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
