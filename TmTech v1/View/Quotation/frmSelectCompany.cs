using ModernUI.Forms;
using System;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class frmSelectCompany : MetroForm
    {

        Company m_Comapny;
        WhichForm.FromForm m_Form;
        public frmSelectCompany(WhichForm.FromForm whichF)
        {
            InitializeComponent();
            m_Form = whichF;
        }
        void _CreateQuotationCode(Company _company, DateTime ngaylap)
        {
            string quoatationCode = string.Empty;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                quoatationCode = uow.QuotationRepository.GetQuotationCode(_company.CompanyId, ngaylap);
            }
        }
        private void SelectCompanyMakeQuotation_Load(object sender, EventArgs e)
        {
            Utility.ComboboxUtility.BindCompany(cbbCompany);
            cbbCompany.SelectedValue = -1;
        }

        private void cbbCompany_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (cbbCompany.SelectedItem != null)
            {
                m_Comapny = cbbCompany.SelectedItem as Company;
                txtCompanyEmail.Text = m_Comapny.Email;
                txtCompanyAddress.Text = m_Comapny.Address;
                txtCompanyPhone.Text = m_Comapny.Phone;
                txtDeputyName.Text = m_Comapny.MainDeputy.DeputyName;
                txtDeputyAddress.Text = m_Comapny.MainDeputy.Address;
                txtDeputyEmail.Text = m_Comapny.MainDeputy.Email;
                txtDeputyPhone.Text = m_Comapny.MainDeputy.Phone;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if (m_Comapny == null)
            //{
            //    return;
            //}
            //if (m_Form == WhichForm.FromForm.PoForm)
            //{
                
            //    Po newPO = new Po();
            //    newPO.Company = m_Comapny;
            //    newPO.CompanyId = m_Comapny.CompanyId;
            //    frmCreatePo frmCreate = new frmCreatePo(newPO);
            //    Close();
            //    frmCreate.ShowDialog();
                
            //}
            //else
            //{
            //    //_CreateCodeQuoation(m_Comapny, dtpNgayLap.Value);
            //    Quotation quotation = new Quotation();
            //    quotation.Company = m_Comapny;
            //    quotation.CusId = m_Comapny.CompanyId;
            //    frmCreateQuotation frmCreate = new frmCreateQuotation(quotation);
            //    Close();
            //    frmCreate.ShowDialog();
                
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class WhichForm
    {
        public enum FromForm { PoForm, QuotationForm };
    }
}
