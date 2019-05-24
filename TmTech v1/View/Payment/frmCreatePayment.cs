using System;
using System.Collections.Generic;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreatePayment : ModernUI.Forms.MetroForm
    {
        public delegate void delgInsert(Payment pay, CRUD crud);
        public delgInsert insert;
        public frmCreatePayment()
        {
            InitializeComponent();
            txtPaymentCode.Select();
        }

        private void frmCreatePayment_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            IList<Company> lstcom = new List<Company>();
            IList<PaymentMethod> lstPm = new List<PaymentMethod>();
            IList<Bank> lstBank = new List<Bank>();
            IList<Staff> lstStaff = new List<Staff>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstcom = uow.CompanyRepository.All();
                lstPm = uow.PaymentMethodRepository.All();
                lstBank = uow.BankBaseRepository.All();
                lstStaff = uow.StaffRepository.All();
                uow.Commit();
            }
            ComboboxUtility.BindData(cbbCompany, lstcom, "CompanyName","CompanyId");
            ComboboxUtility.BindData(cbbPaymentMethod, lstPm, "Name", "PaymentMethodId");
            ComboboxUtility.BindData(cbbBank, lstBank, "BankName", "BankId");
            ComboboxUtility.BindData(cbbStaff, lstStaff, "StaffName", "StaffId");
            cbbStaff.SelectedValue = cbbPO.SelectedValue = cbbPaymentMethod.SelectedValue = cbbCompany.SelectedValue = cbbBank.SelectedValue = -1;
            dtpPaidDate.EditValue = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cbbCompany.SelectedValue == null || cbbPO.SelectedValue==null||cbbStaff.SelectedValue==null||txtPaid.Text==""||txtPaymentName.Text=="")
            {
                labelNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            Payment payment = new Payment();
            payment.PaymentCode = txtPaymentCode.Text;
            payment.PaymentName = txtPaymentName.Text;
            payment.CusId = Convert.ToInt32(cbbCompany.SelectedValue);
            payment.POId = new Guid(cbbPO.SelectedValue.ToString());
            payment.Paid = Convert.ToDouble(txtPaid.Text.Replace(".", ""));
            payment.PaidDate = (DateTime)dtpPaidDate.EditValue;
            payment.PaymentMethodId = Convert.ToInt32(cbbPaymentMethod.SelectedValue);
            payment.PaymentMethod.Name = (cbbPaymentMethod.SelectedItem as PaymentMethod).Name;
            payment.BankId = Convert.ToInt32(cbbBank.SelectedValue);
            payment.StaffId = Convert.ToInt32(cbbStaff.SelectedValue);
            payment.Staff.StaffName = (cbbStaff.SelectedItem as Staff).StaffName;
            payment.Note = txtNote.Text;
            payment.SetCreate();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PaymentRepository.Add(payment);
                    uow.Commit();
                }
            }
            catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (insert != null)
                insert(payment, CRUD.Insert);
            this.Close();
        }

        private void cbbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            IList<Po> lstPo = new List<Po>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstPo = uow.PoRepository.Find((cbbCompany.SelectedItem as Company));
                    uow.Commit();
                }
                ComboboxUtility.BindData(cbbPO, lstPo, "PoCode", "PoId");
            }
            catch { }
        }
    }
}
