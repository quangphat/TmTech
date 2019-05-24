using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmCreateDebt : ModernUI.Forms.MetroForm
    {
        private Debt m_Debt;
        GridUtility gridUtility;
        public frmCreateDebt(Debt debt)
        {
            InitializeComponent();
            
            gridUtility = new GridUtility(gridControl1);
            FormUtility.FormatForm(this);
            m_Debt = debt;
        }

        private void frmCreateDebt_Load(object sender, EventArgs e)
        {
            InitializeForm(m_Debt);
            LoadGrid();
        }
        private void LoadGrid()
        {
            IList<DebtDetail> lstDebtDetail;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDebtDetail = uow.DebtRepository.Find(m_Debt);
                uow.Commit();
            }
            gridUtility.BindingData( lstDebtDetail);

        }
        private void InitializeForm(Debt debt)
        {
            CoverObjectUtility.SetAutoBindingData(this,debt);
        }
        private void InitializeForm(DebtDetail detail)
        {
            //txtNote.Text = detail.Note;
            //txtThanhtien.Text = CurrencyUtility.DecimalToString(detail.Payment);
            //dtpPaymentDay.DateTime = detail.PaymentDate != null ? detail.PaymentDate.Value : DateTime.MinValue;
            //txtReqCode.Text = detail.RequestPaymentCode;
            //txtDetailId.Text = detail.DebtDetailId.ToString();
            CoverObjectUtility.SetAutoBindingData(this, detail);
        }
        public delegate void delgUpdateRow(Debt debt, CRUD flag);
        public delgUpdateRow UpdateRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DebtDetail detail = new DebtDetail();
            if (!string.IsNullOrWhiteSpace(txtThanhtien.Text) || DateTime.Compare(dtpPaymentDay.DateTime,UtilityFunction.minDate)>0)
            {
                detail.SetCreate();
                //detail.Payment = CurrencyUtility.ToDecimal(txtThanhtien.Text);
                //detail.PaymentDate = UtilityFunction.GetDatetime(dtpPaymentDay);
                //detail.RequestPaymentCode = txtReqCode.Text;
                //detail.Note = txtNote.Text;
                detail.DebtId = m_Debt.DebtId;
                CoverObjectUtility.GetAutoBindingData(this, detail);
                //detail.DebtDetailId = string.IsNullOrWhiteSpace(txtDetailId.Text)==false? Convert.ToInt32(txtDetailId.Text):0;
            }
            else
                detail = null;
            m_Debt.Bill = txtBill.Text;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    if(detail!=null)
                    {
                        DebtDetail exist = uow.DebtDetailRepository.Find(detail.DebtDetailId);
                        if (exist == null)
                        {
                            uow.DebtDetailRepository.Add(detail);
                            gridUtility.AddNewRow<DebtDetail>(detail);
                        }
                        else
                        {
                            uow.DebtDetailRepository.Update(detail);
                            gridUtility.UpdateRow<DebtDetail>(detail);
                        }
                    }
                    uow.DebtRepository.Update(m_Debt);
                    uow.Commit();
                }
                m_Debt.TotalPayment += detail.Payment;
                if (UpdateRow != null)
                    UpdateRow(m_Debt, CRUD.Update);
                gridView1.RefreshData();
            }
            catch
            {
            }

        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {
            decimal val = CurrencyUtility.ToDecimal(txtThanhtien.Text);
            txtThanhtien.Text = CurrencyUtility.DecimalToString(val);
            txtThanhtien.SelectionStart = txtThanhtien.Text.Length;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            DebtDetail detail = gridView1.GetRow(i) as DebtDetail;
            if (detail == null) return;
            InitializeForm(detail);
        }

        private void AddOrUpdate(DebtDetail detail, CRUD flag)
        {
            if(flag== CRUD.Insert)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.DebtDetailRepository.Add(detail);
                        uow.Commit();
                    }
                    gridUtility.AddNewRow<DebtDetail>(detail);
                }
                catch
                { }
            }
        }
        private void btnPaymentRequest_Click(object sender, EventArgs e)
        {
            PaymentRequest request = new PaymentRequest();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    request.RequestCode = uow.RequestPaymentBaseRepository.GetRequestPaymentCode(m_Debt.Company.CompanyId, DateTime.Now);
                    uow.Commit();
                }
                request.CompanyId = m_Debt.Company.CompanyId;
                request.POCode = m_Debt.POCode;
                frmSendPaymentRequest frmCreate = new frmSendPaymentRequest(request);
                frmCreate.AddRequestCode = AddOrUpdate;
                frmCreate.ShowDialog();
            }
            catch
            {

            }
        }

        private void autoTextBox1_TextChanged(object sender, EventArgs e)
        {
            double percent = string.IsNullOrWhiteSpace(autoTextBox1.Text) == true ? 0 : Convert.ToDouble(autoTextBox1.Text);
            textBox9.Text = CurrencyUtility.DecimalToString(CurrencyUtility.PercentToMoney(percent / 100, m_Debt.TotalValue));
        }
    }
}
