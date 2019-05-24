using ModernUI.Forms;
using System;
using System.Collections.Generic;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditDepartment : MetroForm
    {
        Department m_dep;
        public frmEditDepartment()
        {
            InitializeComponent();
        }
        public frmEditDepartment(Department dep)
        {
            InitializeComponent();
            m_dep = dep;
        }

        private void loadStaff()
        {
            IList<Staff> lstStaff;
            using (UnitOfWork uow = new UnitOfWork())
            {
                lstStaff = uow.StaffRepository.All();
                uow.Commit();
            }
            ComboboxUtility.BindData<Staff>(cbbStaff, lstStaff, "StaffName", "StaffId");
        }

        public delegate void delgUpdateRow(Department department);
        public delgUpdateRow UpdateRow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_dep == null) return;

            CoverObjectUtility.GetAutoBindingData(this, m_dep);
            m_dep.SetModify();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.DepartmentRepository.Update(m_dep);
                    uow.Commit();
                }
            } catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            if (UpdateRow != null)
                UpdateRow(m_dep);
            this.Close();
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmEditDepartment_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            CoverObjectUtility.SetAutoBindingData(this, m_dep);
            loadStaff();

            m_dep.Staff = new Staff();
            using (UnitOfWork uow = new UnitOfWork())
            {
                m_dep.Staff = uow.StaffRepository.Find((int)m_dep.HeaderId);
            }
            cbbStaff.SelectedValue = (m_dep.Staff != null) ? m_dep.Staff.StaffId : 0;
        }
    }
}
