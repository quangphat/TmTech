using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmCreatePaymentMethod : ModernUI.Forms.MetroForm
    {
        public delegate void delginsert(PaymentMethod pm, CRUD cru);
        public delginsert insert;

        public frmCreatePaymentMethod()
        {
            InitializeComponent();
        }

        private void frmCreatePaymentMethod_Load(object sender, System.EventArgs e)
        {
            labelNotify1.Text = "";
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            PaymentMethod pm = new PaymentMethod();
            CoverObjectUtility.GetAutoBindingData(this, pm);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PaymentMethodRepository.Add(pm);
                    uow.Commit();
                }
            } catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (insert != null)
                insert(pm, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
