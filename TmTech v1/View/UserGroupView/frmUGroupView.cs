using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TmTech_v1.Utility;
using FlatMessageBox;
using TmTech_v1.Model;
using TmTech_v1.Interface;
namespace TmTech_v1.View
{
    public partial class frmUGroupView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        GridUtility gridUtility;
        public bool isLoadAll;
        public frmUGroupView()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        internal void LoadGrid()
        {
            IList<UserGroup> lstUserGroup;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstUserGroup = uow.UserGroupRepository.All();
                uow.Commit();
            }
            if(lstUserGroup!=null)
            {
                gridUtility.BindingData<UserGroup>( lstUserGroup);
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //UserGroup ugroup = metroGrid1.SelectedRows[0].DataBoundItem as UserGroup;
            //if (ugroup == null)
            //    return;
            //if (UserManagement.AllowDelete("UserGroup") == true && UserManagement.AllowDelete("Permissions") == true)
            //{
            //    DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa ?","Cảnh báo", FlatMsgBox.Buttons.YesNo);
            //    if(result== DialogResult.Yes)
            //    {
            //        if(UtilityFunction.Delete(ugroup.Id, "UserGroup")==true)
            //        {
            //            FlatMessageBox.FlatMsgBox.Show("Success");
            //            //LoadUserGroup(metroGrid1);
            //        }
            //        else
            //        {
            //            FlatMessageBox.FlatMsgBox.Show("Failed");
            //        }
            //    }
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền tạo mới");
            //}
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("UserGroup") == true && UserManagement.AllowCreate("Permissions")==true)
            {
                frmCreateUGroup frmCreate = new frmCreateUGroup();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (UserManagement.AllowEdit("UserGroup") == true && UserManagement.AllowEdit("Permissions") == true)
            //{
            //    UserGroup uGroup = metroGrid1.SelectedRows[0].DataBoundItem as UserGroup;
            //    frmCreateUGroup frmCreate = new frmCreateUGroup(uGroup);
            //    frmCreate.Show();
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền tạo mới");
            //}
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }
    }
}
