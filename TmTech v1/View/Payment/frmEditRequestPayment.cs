using System;
using ModernUI.Forms;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditRequestPayment : MetroForm
    {
        //private readonly RequestPaymentParameter _requestPaymentParameter;
        //private readonly IRequestPaymentBussiness _iRequestPaymentBussiness;
        //public frmEditRequestPayment(RequestPaymentParameter requestPaymentParameter)
        //{
        //    InitializeComponent();
        //    _requestPaymentParameter = requestPaymentParameter;
        //    _iRequestPaymentBussiness = new RequestPaymentBussiness();
        //}
        public frmEditRequestPayment(PaymentRequest paymentRequest)
        {
            InitializeForm(paymentRequest);
        }
        private void InitializeForm(PaymentRequest request)
        {
            txtCode.Text = request.RequestCode;
        }
        //void Initdata()
        //{
        //    if (_requestPaymentParameter.IsEdit)
        //    {
        //        var requestPayment = _requestPaymentParameter.RequestPayment;
        //        txtCode.Text = requestPayment.RequestCode;
        //        txtContent.Text = requestPayment.RequestContent;
        //        txtEmail.Text = requestPayment.Email;
        //        txtTitle.Text = requestPayment.Title;
        //        lblTitleForm.Text = "Chỉnh sửa " + "Yêu cầu hình thức thanh toán";
        //    }
        //    else
        //    {

        //        lblTitleForm.Text = "Tạo mới" + "Yêu cầu hình thức thanh toán";
        //        FormUtility.ResetAllControls(this); txtCode.Text = "xxxxxxxxxxxx";

        //    }
        //}

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
           
        }
        private void RequestPayment_Load(object sender, System.EventArgs e)
        {
            //Initdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
