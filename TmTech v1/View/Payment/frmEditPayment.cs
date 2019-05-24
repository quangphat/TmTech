using System;
using System.Collections.Generic;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditPayment : ModernUI.Forms.MetroForm
    {
        Payment pay;
        public delegate void delgUpdate(Payment pay, CRUD crud);
        public delgUpdate update;
        public frmEditPayment(Payment pay)
        {
            InitializeComponent();
            this.pay = pay;
        }

        private void frmEditPayment_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            if (pay == null)
                return;
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
            ComboboxUtility.BindData(cbbCompany, lstcom, "CompanyName", "CompanyId");
            ComboboxUtility.BindData(cbbPaymentMethod, lstPm, "Name", "PaymentMethodId");
            ComboboxUtility.BindData(cbbBank, lstBank, "BankName", "BankId");
            ComboboxUtility.BindData(cbbStaff, lstStaff, "StaffName", "StaffId");

            txtPaymentCode.Text = pay.PaymentCode;
            txtPaymentName.Text = pay.PaymentName;
            txtPaid.Text = pay.Paid.ToString();
            txtNote.Text = pay.Note;
            cbbBank.SelectedValue = pay.BankId;
            cbbCompany.SelectedValue = pay.CusId;
            cbbPaymentMethod.SelectedValue = pay.PaymentMethodId;
            cbbPO.SelectedValue = pay.POId;
            cbbStaff.SelectedValue = pay.StaffId;
            dtpPaidDate.EditValue = pay.PaidDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPaid.Text==""||txtPaymentName.Text=="")
            {
                labelNotify1.SetText(UI.hasnoinfomation, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            pay.PaymentCode = txtPaymentCode.Text;
            pay.PaymentName = txtPaymentName.Text;
            pay.POId = new Guid(cbbPO.SelectedValue.ToString());
            pay.CusId = Convert.ToInt32(cbbCompany.SelectedValue);
            pay.Paid = Convert.ToDouble(txtPaid.Text.Replace(".", ""));
            pay.Staff.StaffName = (cbbStaff.SelectedItem as Staff).StaffName;
            pay.StaffId = Convert.ToInt32(cbbStaff.SelectedValue);
            pay.PaidDate = (DateTime)dtpPaidDate.EditValue;
            pay.PaymentMethodId = Convert.ToInt32(cbbPaymentMethod.SelectedValue);
            pay.PaymentMethod.Name = (cbbPaymentMethod.SelectedItem as PaymentMethod).Name;
            pay.Note = txtNote.Text;
            pay.BankId = Convert.ToInt32(cbbBank.SelectedValue);
            pay.Bank.BankName = (cbbBank.SelectedItem as Bank).BankName;
            pay.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.PaymentRepository.Update(pay);
                    uow.Commit();
                }
            }
            catch 
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (update != null)
                update(pay, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbCompany_SelectedIndexChanged(object sender, EventArgs e)
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
