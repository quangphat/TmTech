using ModernUI.Forms;
using System;
using System.Collections.Generic;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmCreateDepartment : MetroForm
    {
        public frmCreateDepartment()
        {
            InitializeComponent();
        }

        private void frmCreateDepartment_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            IList<Staff> lstStaff;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstStaff = uow.StaffRepository.All();
                    uow.Commit();
                }
                ComboboxUtility.BindData<Staff>(cbbStaff, lstStaff, "StaffName", "StaffId");
                cbbStaff.SelectedValue = -1;
            }
            catch (Exception)
            {

            }
        }

        public delegate void delgAddRow(Department department);
        public delgAddRow Addrow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidationUtility.FieldNotAllowNull(this)==false)
            {
                return;
            }
            Department department = new Department();
            CoverObjectUtility.GetAutoBindingData(this, department);
            department.SetCreate();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DepartmentRepository.Add(department);
                    uow.Commit();
                }
                if (Addrow != null)
                {
                    Addrow(department);
                }
                this.Close();
            }
            catch 
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
