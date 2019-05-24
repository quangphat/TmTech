using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using TmTech_v1.Interface;

namespace TmTech_v1.View
{
    public partial class frmDepartmentView : UserControl
    {
        GridUtility gridUtility;
        public frmDepartmentView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            LoadGrid();
            
        }

        public void LoadGrid()
        {
            IList<Model.Department> lstDepartment;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstDepartment = uow.DepartmentRepository.All();
                uow.Commit();
            }
            gridUtility.BindingData<Model.Department>( lstDepartment);
        }

        private void AddRow(Department department)
        {
            if (department == null) return;
            gridUtility.AddNewRow<Department>( department);
            gridControl1.RefreshDataSource();
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateDepartment obj = new frmCreateDepartment();
            obj.Addrow = AddRow;
            obj.Show();
            
        }

        private void UpdateRow(Department deparment)
        {
            if (deparment == null) return;
            gridUtility.UpdateRow<Department>( deparment);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            Department dep = gridView1.GetRow(i) as Department;
            if (dep == null) return;
            frmEditDepartment obj = new frmEditDepartment(dep);
            obj.UpdateRow = UpdateRow;
            obj.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];

            Department dep = gridView1.GetRow(i) as Department;
            if (dep == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DepartmentRepository.Remove(dep);
                    uow.Commit();
                }
                gridView1.DeleteRow(i);
                gridView1.RefreshData();
            } catch { }
            
        }
    }
}
