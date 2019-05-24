using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmEditCurrencyUnit : ModernUI.Forms.MetroForm
    {
        private CurrencyUnit cu;
        public frmEditCurrencyUnit(CurrencyUnit cu)
        {
            InitializeComponent();
            this.cu = cu;
        }

        private void frmEditCurrencyUnit_Load(object sender, System.EventArgs e)
        {
            //Load information
            CoverObjectUtility.SetAutoBindingData(this, cu);
            labelNotify1.Text = "";

        }
        public delegate void delgInsertCurrencyUnit(Model.CurrencyUnit cu, Utility.CRUD cru);
        public delgInsertCurrencyUnit updateCurrencyUnit;
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, cu);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.CurrencyUnitRepository.Update(cu);
                    uow.Commit();
                }
            } catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (updateCurrencyUnit != null)
                updateCurrencyUnit(cu, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
