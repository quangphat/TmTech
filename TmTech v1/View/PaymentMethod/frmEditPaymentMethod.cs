using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditPaymentMethod : ModernUI.Forms.MetroForm
    {
        private PaymentMethod pm;
        public delegate void delgupdate(PaymentMethod pm, CRUD cru);
        public delgupdate update;
        public frmEditPaymentMethod(PaymentMethod pm)
        {
            InitializeComponent();
            this.pm = pm;
        }

        private void frmEditPaymentMethod_Load(object sender, EventArgs e)
        {
            if (pm == null)
                return;
            labelNotify1.Text = "";
            CoverObjectUtility.SetAutoBindingData(this, pm);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, pm);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PaymentMethodRepository.Update(pm);
                    uow.Commit();
                }
            } catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (update != null)
                update(pm, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
