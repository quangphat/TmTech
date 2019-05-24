using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateCurrencyUnit : ModernUI.Forms.MetroForm
    {
        public frmCreateCurrencyUnit()
        {
            InitializeComponent();
            AcceptButton = btnAdd;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public delegate void delgAddnewCurrency(Model.CurrencyUnit cu, Utility.CRUD cru);
        public delgAddnewCurrency insertCurrency;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
            {
                return;
            }
            Model.CurrencyUnit cu = new Model.CurrencyUnit();
            CoverObjectUtility.GetAutoBindingData(this, cu);
            try
            {
                using (Interface.IUnitOfWork uow = new UnitOfWork())
                {
                    uow.CurrencyUnitRepository.Add(cu);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (insertCurrency != null)
                insertCurrency(cu, Utility.CRUD.Insert);
            Close();
        }

        private void frmCreateCurrencyUnit_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
        }
    }
}
