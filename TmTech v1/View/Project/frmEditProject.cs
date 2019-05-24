using System;
using System.Collections.Generic;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditProject : ModernUI.Forms.MetroForm
    {
        private Project pro;
        public delegate void delgupdate(Project ppro, CRUD cru);
        public delgupdate update;
        public frmEditProject(Project pro)
        {
            InitializeComponent();
            this.pro = pro;
        }

        private void frmEditProject_Load(object sender, EventArgs e)
        {
            if (pro == null)
                return;
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
            CoverObjectUtility.SetAutoBindingData(this, pro);
            //if (pro.Sale != null)
            //    cbbSale.SelectedValue = pro.Sale;
            //else
            //    cbbSale.SelectedValue = -1;
            //if (pro.CompanyId != null)
            //    cbbCompany.SelectedValue = pro.CompanyId;
            //else
            //    cbbCompany.SelectedValue = -1;
            //if (pro.StatusId != null)
            //    cbbStatus.SelectedValue = pro.StatusId;
            labelNotify1.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbCompany.SelectedValue == null || cbbSale.SelectedValue == null || cbbStatus.SelectedValue == null || !ValidationUtility.FieldNotAllowNull(this))
            {
                labelNotify1.SetText(UI.MsgMissingData, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            CoverObjectUtility.GetAutoBindingData(this, pro);
            //pro.ProjectName = txtProjectName.Text;
            //pro.DrawingName = txtDrawingName.Text;
            //pro.DateBegin = (DateTime)dtpDateBegin.EditValue;
            //pro.DateEnd = (DateTime)dtpDateEnd.EditValue;
            //pro.ProjectCode = txtProjectCode.Text;
            //pro.Sale = Convert.ToInt32(cbbSale.SelectedValue);
            //pro.CompanyId = Convert.ToInt32(cbbCompany.SelectedValue);
            //pro.StatusId = Convert.ToInt32(cbbStatus.SelectedValue);
            pro.SetModify();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.ProjectBaseRepository.Update(pro);
                uow.Commit();
            }
            if (update != null)
                update(pro, CRUD.Update);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
