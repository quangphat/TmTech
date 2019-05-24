using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{

    public sealed partial class FrmCompany : UserControl
    {
       
        GridUtility gridUtility1;
        GridUtility gridUtility2;
        Company m_Company;
        Deputy m_Deputy;
        Users m_User;
        public FrmCompany()
        {
            InitializeComponent();
            FormUtility.FormatForm(this);
            lblNotify1.Text = "";
            m_Company = null;
            m_Deputy = null;
            m_User = null;
            IGridviewContextMenu ctx = new CompanyContextMenu();
            IGridviewContextMenu ctxDeputy = new DeputyContextMenu();
            gridUtility1 = new GridUtility(gridControl1,ctxDeputy);
            gridUtility2 = new GridUtility(gridControl2,ctx);
        }
        private void FrmCompany_Load(object sender, EventArgs e)
        {
            LoadCompany();
            InitializeForm(new Company());
        }
        private void LoadCompany()
        {
            IList<Company> lstCompany;
            List<CompanyClass> lstClass;
            List<CompanyType> lstType;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCompany = uow.CompanyRepository.All();
                lstClass = uow.CompanyRepository.AllClass();
                lstType = uow.CompanyTypeRepository.All();
                uow.Commit();
            }
            gridUtility2.BindingData(lstCompany);
            ComboboxUtility.BindCompanyClass(cbbClass, lstClass, 0);
            ComboboxUtility.BindCompanyType(cbbType, lstType, 0);
        }
        private void LoadDeputy(Company company, IList<Deputy> lstDeputy =null)
        {
            if (lstDeputy == null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstDeputy = uow.DeputyRepository.GetByCompany(company);
                    uow.Commit();
                }
            }
            gridUtility1.BindingData<Deputy>(lstDeputy);
            if (lstDeputy != null)
            {
                m_Deputy = lstDeputy.Where(p => p.IsMain == true).FirstOrDefault();
                if (m_Deputy == null) m_Deputy = new Deputy();
                InitializeForm(m_Deputy);
            }
            //cbbIsMainDeputy.Checked = deputy.IsMain;
        }
        private void InitializeForm(Company company)
        {
            if (company == null) company = new Company();
            txtCompanyName.Display(company.ApproveStatusId);
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel1, company);
            if (company.CompanyId <= 0) btnSaveCompany.Visible = false;
            else btnSaveCompany.Visible = true;
            //LoadDeputy(company);
        }
        private void InitializeForm(Deputy deputy)
        {
            m_User = deputy.User;
            if(deputy.User==null) m_User = new Users();
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel2, m_User);
            CoverObjectUtility.SetAutoBindingData(this.tableLayoutPanel2, deputy);
            cbbIsMainDeputy.Checked = deputy.IsMain;
            cbActive.Checked = deputy.IsActive;
            if (deputy.User.Sex == true) rdNam.Checked = true;
            else
                rdNu.Checked = true;
            if (deputy.DeputyId <= 0)
                btnSaveDeputy.Visible = false;
            else
                btnSaveDeputy.Visible = true;
        }
        
        

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility2.SetRowColor();
            m_Company = gridUtility2.GetSelectedItem<Company>() as Company;
            if (m_Company == null) return;
            IList<Deputy> lstDeputy;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDeputy = uow.DeputyRepository.GetByCompany(m_Company);
                m_Company = uow.CompanyRepository.Find(m_Company.CompanyId);
                uow.Commit();
            }
            InitializeForm(m_Company);
            LoadDeputy(m_Company, lstDeputy);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility1.SetRowColor();
            m_Deputy = gridUtility1.GetSelectedItem<Deputy>();
            if (m_Deputy == null) return;
            m_User = UtilityFunction.GetUser(m_Deputy);
            if (m_User == null) return;
            m_Deputy.User = m_User;
            InitializeForm(m_Deputy);
            
        }

        private void SaveCompany(Company compny)
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (compny.CompanyId > 0)
                {
                    uow.CompanyRepository.Update(compny);
                }
                else
                {
                    uow.CompanyRepository.Add(compny);
                }
                uow.Commit();
            }
        }
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(txtCompanyCode) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_Company == null) return;
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel1, m_Company);
            if (m_Deputy.CompanyId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Deputy.SetModify();
            try
            {
                SaveCompany(m_Company);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                gridUtility2.UpdateRow<Company>(m_Company);
                InitializeForm(m_Company);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(txtCompanyCode)==false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Company = new Company();
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel1, m_Company);
            m_Company.ApproveStatusId = (int)ApproveStatus.Wait;
            m_Company.SetCreate();
            m_Company.CompanyId = 0;
            try
            {
                var count = 0;
                using (IUnitOfWork uow =new UnitOfWork())
                {
                    count= uow.CompanyRepository.CheckExitCompany(m_Company);
                }
                if(count >0)
                {
                    lblNotify1.SetText(UI.CompanyisExists, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    return;
                }
                SaveCompany(m_Company);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                gridUtility2.AddNewRow<Company>(m_Company);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private Deputy SaveAccount(Users user)
        {
            int companyId = string.IsNullOrWhiteSpace(txtCompanyId.Text) == false ? Convert.ToInt32(txtCompanyId.Text) : 0;
            if (companyId <= 0)
            {
                lblNotify1.SetText(UI.deputyhasnocompany, LabelNotify.EnumStatus.Failed);
                return null;
            }
            if (ValidationUtility.IsTextAllowed(user.UserName) == false)
            {
                lblNotify1.SetText(UI.usernotallowspace, LabelNotify.EnumStatus.Failed);
                return null;
            }
            user.Sex = rdNam.Checked == true ? true : false;
            user.SetCreate();
            user.UserGroupId = (int)UserTypeFlag.Customer;
            m_Deputy = new Deputy();
            CoverObjectUtility.GetAutoBindingData(tableLayoutPanel2, m_Deputy);
            if (user.UserId <= 0)
                m_Deputy.DeputyId = 0;
            m_Deputy.DeputyName = user.FullName;
            m_Deputy.IsActive = cbActive.Checked;
            m_Deputy.Email = user.Email;
            m_Deputy.Phone = user.Phone;
            m_Deputy.Address = user.Address;
            m_Deputy.Sex = user.Sex;
            m_Deputy.UserId = user.UserId;
            m_Deputy.CompanyId = companyId;
            
            IList<Deputy> lstExistsDeputy = gridControl1.DataSource as IList<Deputy>;
            Deputy main = lstExistsDeputy != null ? lstExistsDeputy.Where(p => p.IsMain == true && p.DeputyId != m_Deputy.DeputyId).FirstOrDefault() : null;
            if (main == null)
                m_Deputy.IsMain = true;
            else
                m_Deputy.IsMain = false;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (user.UserId <= 0)
                {
                    uow.UsersRepository.Add(user);
                    m_Deputy.SetCreate();
                    m_Deputy.UserId = user.UserId;
                    m_Deputy.DeputyId = 0;
                    uow.DeputyRepository.Add(m_Deputy);
                    
                }
                else
                {
                    uow.UsersRepository.Update(user);
                    m_Deputy.SetModify();
                    uow.DeputyRepository.Update(m_Deputy);
                    
                }
                uow.Commit();
            }
            return m_Deputy;
        }
        private void btnSaveDeputy_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(groupBox1) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
            if (m_User == null) return;
            CoverObjectUtility.GetAutoBindingData(groupBox1, m_User);
            if (m_User == null) return;
            try
            {
                if (SaveAccount(m_User) == null)
                {
                    return;
                }
                if(!string.IsNullOrWhiteSpace(ptbSignature.PictureOriginPath))
                    PictureUtility.SaveImg(ptbSignature.PictureOriginPath);
                if(!string.IsNullOrWhiteSpace(ptbAvatar.PictureOriginPath))
                    PictureUtility.SaveImg(ptbAvatar.PictureOriginPath);
                gridUtility1.UpdateRow<Deputy>(m_Deputy);
                lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, LabelNotify.EnumStatus.Failed);
            }
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(groupBox1) == false)
            {
                lblNotify1.SetText(UI.hasnoinfomation, LabelNotify.EnumStatus.Failed);
                return;
            }
           
          

            if (m_User == null) m_User = new Users();
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel2, m_User);

            if (string.IsNullOrWhiteSpace(m_User.Password))
            {
                m_User.Password = UtilityFunction.GetSHA256Hash(m_User.UserName);
            }
            m_User.UserId = 0;
            if (m_User == null) return;
            try
            {
                SaveAccount(m_User);
                lblNotify1.SetText(UI.success, LabelNotify.EnumStatus.Success);
                gridUtility1.AddNewRow<Deputy>(m_Deputy);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, LabelNotify.EnumStatus.Failed);
            }
        }
        private void lnkSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbSignature);
        }

        private void lnkPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptbAvatar);
        }

        private void lnkSetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_User == null) return;
            CoverObjectUtility.GetAutoBindingData(this.tableLayoutPanel2, m_User);
            frmSetPassword frmSetPass = new frmSetPassword(m_User);
            frmSetPass.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            if(m_User==null || m_Deputy==null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DeputyRepository.Remove(m_Deputy.DeputyId);
                    uow.UsersRepository.Remove(m_User.UserId);
                    uow.Commit();
                }
                m_Deputy = new Deputy();
                m_User = new Users();
                InitializeForm(m_Deputy);
                gridView1.DeleteRow(i);
                lblNotify1.SetText(UI.removesuccess, LabelNotify.EnumStatus.Success);
            }
            catch
            {
                lblNotify1.SetText(UI.removefailed, LabelNotify.EnumStatus.Failed);
            }
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridUtility2.DrawStatusColor(sender, e, colStatus, colCompanyName);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (m_Company == null) return;
            m_Company.ApproveStatusId = (int)ApproveStatus.Approved;
            if (m_Company.CompanyId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Company.SetModify();
            m_Company.ApproveBy = UserManagement.UserSession.UserName;
            m_Company.ApproveDate = DateTime.Now;
            try
            {
                SaveCompany(m_Company);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                gridUtility2.UpdateRow<Company>(m_Company);
                InitializeForm(m_Company);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            if (m_Company == null) return;
            m_Company.ApproveStatusId = (int)ApproveStatus.Cancel;
            if (m_Company.CompanyId <= 0)
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            m_Company.SetModify();
            m_Company.ApproveBy = UserManagement.UserSession.UserName;
            m_Company.ApproveDate = DateTime.Now;
            try
            {
                SaveCompany(m_Company);
                lblNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Success);
                gridUtility2.UpdateRow<Company>(m_Company);
                InitializeForm(m_Company);
            }
            catch
            {
                lblNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void linkCreateCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void SearchCompany()
        {
            IList<Company> lstCompany;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCompany = uow.CompanyRepository.SearchCompany(txtSearch.Text);
                uow.Commit();
            }
            gridUtility2.BindingData<Company>(lstCompany);
        }
        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            SearchCompany();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                SearchCompany();
        }

        private void AutoTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
