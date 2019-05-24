using ModernUI.Forms;
using System;
using TmTech_v1.Model;
using TmTech.SDK.Mail;
using TmTech_v1.Interface;
using TmTech.Resource;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmSendPaymentRequest : MetroForm
    {
        readonly PaymentRequest _mReq;
        public frmSendPaymentRequest(PaymentRequest paymentRequest)
        {
            InitializeComponent();
            _mReq = paymentRequest;
            lblNotify.Text = string.Empty;
        }

        private void frmSendPaymentRequest_Load(object sender, EventArgs e)
        {
            InitializeForm(_mReq);
        }
        private void InitializeForm(PaymentRequest request)
        {
            txtCode.Text = request.RequestCode;
        }
        public delegate void delgAddOrUpdateRequest(DebtDetail detail, CRUD flag);
        public delgAddOrUpdateRequest AddRequestCode;
        private void btnSend_Click(object sender, EventArgs e)
        {
            CoverObjectUtility.GetAutoBindingData(this, _mReq);
            _mReq.SetCreate();
            _mReq.Email = txtEmail.Text;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.RequestPaymentBaseRepository.Add(_mReq);
                    uow.Commit();
                }
                InformationMailModel mail = new InformationMailModel();
                mail.Subject = _mReq.Title;
                mail.SendersAddress = "quangphatitu@gmail.com";
                mail.SenderPassword = "còn lâu mới biết";
                mail.Content = _mReq.RequestContent;
                mail.ReceiverAddress = _mReq.Email;
                IMailHandler  iMailHandler =  new MailHandler();
                iMailHandler.SendMail(mail);
                if(AddRequestCode!=null)
                {
                    DebtDetail detail = new DebtDetail();
                    detail.Payment = 0;
                    detail.PaymentDate = null;
                    detail.RequestPaymentCode = _mReq.RequestCode;
                    AddRequestCode(detail, Utility.CRUD.Insert);
                }
                lblNotify.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
