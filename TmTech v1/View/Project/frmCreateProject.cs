using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateProject : ModernUI.Forms.MetroForm
    {
        public delegate void delginsert(Project pro, CRUD cru);
        public delginsert insert;
        public frmCreateProject()
        {
            InitializeComponent();
            AcceptButton = btnCreate;
            txtProjectName.Focus();
            FormUtility.FormatForm(this);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbbCompany.SelectedValue == null || cbbSale.SelectedValue == null || cbbStatus.SelectedValue == null|| !ValidationUtility.FieldNotAllowNull(this))
            {
                labelNotify1.SetText(UI.MsgMissingData, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            Project pro = new Project();
            CoverObjectUtility.GetAutoBindingData(this, pro);
            pro.SetCreate();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ProjectBaseRepository.Add(pro);
                uow.Commit();
            }
            if (insert != null)
                insert(pro, CRUD.Insert);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCreateProject_Load(object sender, EventArgs e)
        {
            IList<Staff> lstSt = new List<Staff>();
            IList<Company> lstCom = new List<Company>();
            IList<Status> lstSta = new List<Status>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSt = uow.StaffRepository.All();
                lstCom = uow.CompanyRepository.All();
                lstSta = uow.ProjectBaseRepository.GetAllStatus();
                uow.Commit();
            }
            ComboboxUtility.BindData(cbbSale, lstSt, "StaffName", "StaffId");
            ComboboxUtility.BindData(cbbCompany, lstCom, "CompanyName", "CompanyId");
            ComboboxUtility.BindData(cbbStatus, lstSta, "StatusName", "StatusId");
            cbbSale.SelectedValue = -1;
            cbbStatus.SelectedValue = -1;
            labelNotify1.Text = "";
        }

        private void cbbCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbCompany.SelectedValue == null)
                return;
            int id = (cbbCompany.SelectedItem as Company).CompanyId;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                txtProjectCode.Text = uow.ProjectBaseRepository.GetProjectCode(id, DateTime.Now);
                uow.Commit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDrawingName.Text = openFileDialog1.SafeFileName;
            }
        }
    }
}
