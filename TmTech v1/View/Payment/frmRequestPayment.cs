using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Bussiness;
using TmTech_v1.Model;


namespace TmTech_v1.View
{
    public partial class frmRequestPayment : UserControl, IHandlerEventDatagridview
    {
        private readonly IRequestPaymentBussiness _requestPaymentBussiness;
        private List<PaymentRequest> _lstRequestPayments;
        public frmRequestPayment()
        {
            InitializeComponent();
            _requestPaymentBussiness= new RequestPaymentBussiness();
            IintData();
        }

        private void IintData()
        {
            if(_lstRequestPayments==null)
                _lstRequestPayments= new List<PaymentRequest>();
            _lstRequestPayments = _requestPaymentBussiness.GetAll().List;
            //griveViewCustomize1.BindingData(_lstRequestPayments);
            //griveViewCustomize1.IsEdit = false;
        }

        public void HandlerEventRowSelect(object T)
        {
            return;
        }

        public void HandlerEventDoubleClick(object T)
        {
            //var requestPayment = griveViewCustomize1.GetSelectedItem<PaymentRequest>();
            //if (requestPayment == null) ;
            //var requestPaymentParameter = new RequestPaymentParameter
            //{
            //   IsEdit = true,
            //   SaveRequest = SaveRequest,
            //   RequestPayment = requestPayment
            //};
            //frmEditRequestPayment frmeditRequestPayment = new frmEditRequestPayment(requestPaymentParameter);
            //frmeditRequestPayment.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            RequestPaymentParameter requestPaymentParameter = new RequestPaymentParameter
            {
               IsEdit = false,
               SaveRequest = SaveRequest
            };
            //frmEditRequestPayment frmeditRequestPayment = new frmEditRequestPayment(requestPaymentParameter);
            //frmeditRequestPayment.ShowDialog();

        }

        private void SaveRequest(RequestPaymentParameter requestPaymentParameter)
        {
            IintData();
        }
    }
}
