using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditUnit : ModernUI.Forms.MetroForm
    {
        Unit m_unit;

        public frmEditUnit(Unit unit)
        {
            InitializeComponent();
            m_unit = unit;
            AcceptButton = btnSave;
        }

        private void frmEditUnit_Load(object sender, EventArgs e)
        {
            if (m_unit != null)
            {
                CoverObjectUtility.SetAutoBindingData(this, m_unit);
                labelNotify1.Text = "";
            }
        }

        public delegate void delgUpdateNewUnit(Unit unit, CRUD crud);
        public delgUpdateNewUnit UpdateNewUnit;

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, m_unit);
            m_unit.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.UnitRepository.Update(m_unit);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            if (UpdateNewUnit != null)
                UpdateNewUnit(m_unit, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
