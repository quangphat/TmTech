using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmDepartmentMain : UserControl
    {
        GridUtility gridUtility1;
        GridUtility gridUtility2;
        GridUtility gridUtility3;
        
        public frmDepartmentMain()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            gridUtility1 = new GridUtility(gridControl1);
            gridUtility2 = new GridUtility(gridControl2);
            gridUtility3 = new GridUtility(gridControl3);
            //FormUtility.LoadEventCommonControl(this);
            //lblNotify1.Text = string.Empty;
        }
        #region Department
        private void LoadDepartment()
        {
            IList<Department> lstDepartment;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDepartment = uow.DepartmentRepository.All();
                uow.Commit();
            }
            gridUtility1.BindingData<Department>(lstDepartment);
            gridUtility3.BindingData<Department>(lstDepartment);
        }

        private void AddnewRow(Department department)
        {
            gridUtility3.AddNewRow<Department>(department);
            gridControl1.RefreshDataSource();
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            frmCreateDepartment obj = new frmCreateDepartment();
            obj.Addrow = AddnewRow;
            obj.ShowDialog();


        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView3.GetSelectedRows().FirstOrDefault();
                Department department = gridView3.GetRow(i) as Department;
                if (department != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.DepartmentRepository.Remove(department);
                            uow.Commit();
                        }
                        gridView3.DeleteRow(i);
                        gridView1.RefreshData();
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }

        private void frmDepartmentMain_Load_1(object sender, EventArgs e)
        {
            LoadDepartment();
            lblNotify1.Text = "";
        }

        private void UpdateRow(Department deparment)
        {
            if (deparment == null) return;
            gridUtility1.UpdateRow<Department>(deparment);
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];

            Department dep = gridView1.GetRow(i) as Department;
            if (dep == null) return;
            frmEditDepartment obj = new frmEditDepartment(dep);
            obj.UpdateRow = UpdateRow;
            obj.ShowDialog();
            Enabled = true;
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            btnEditDepartment.PerformClick();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            btnRemoveDepartment.PerformClick();
        }
        #endregion

        #region Staff
        private void LoadStaff(int departmentId)
        {
            IList<Staff> lstStaff;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstStaff = uow.StaffRepository.FindByDepartment(departmentId);
                uow.Commit();
            }
            gridUtility2.BindingData<Staff>(lstStaff);
        }

        private void AddNewStaff(Staff staff)
        {
            Department department = gridUtility1.GetSelectedItem<Department>() as Department;
            LoadStaff(department.DepartmentId);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateStaff frmCreate = new frmCreateStaff();
            frmCreate.AddnewStaff = AddNewStaff;
            Enabled = false;
            frmCreate.ShowDialog();
            Enabled = true;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Department department = gridUtility1.GetSelectedItem<Department>() as Department;
            if (department == null) return;
            LoadStaff(department.DepartmentId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Staff staff = gridUtility2.GetSelectedItem<Staff>();
            if (staff == null) return;
            frmEditStaff frmEdit = new frmEditStaff(staff);
            Enabled = false;
            frmEdit.ShowDialog();
            Enabled = true;
            gridView2.RefreshData();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView2.GetSelectedRows().FirstOrDefault();
                Staff staff = gridView2.GetRow(i) as Staff;
                if (staff != null)
                {
                    try
                    {
                        using (IUnitOfWork uow = new UnitOfWork())
                        {
                            uow.StaffRepository.Remove(staff);
                            uow.Commit();
                        }
                        gridView2.DeleteRow(i);
                    }
                    catch
                    {
                        lblNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    }
                }
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Staff staff = gridUtility2.GetSelectedItem<Staff>();
            if (staff == null)
                return;

            PictureUtility.BindImage(ptAvatar, staff.Avatar);
            PictureUtility.BindImage(ptSignature, staff.SignaturePhoto);
            txtCreatedBy.Text = staff.CreateBy;

            txtCreatedDate.Text = staff.CreateDate != null ? UtilityFunction.DateTimeToString(staff.CreateDate.Value) : "";
            txtModifiedBy.Text = staff.ModifyBy;
            txtModifiedDate.Text = staff.ModifyDate != null ? UtilityFunction.DateTimeToString((DateTime)staff.ModifyDate) : "";
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            btnDelete.PerformClick();
        }
        #endregion


    }
}
