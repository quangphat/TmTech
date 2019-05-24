using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Utility;
using Dapper;
using FlatMessageBox;
using TmTech_v1.Model;
using ModernUI.Controls;
namespace TmTech_v1.View
{
    public partial class frmSetPermission : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        public bool isLoadAll;
        public frmSetPermission()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //LoadUser(true,grid);
        }

        public void LoadGrid()
        {
            LoadTableName(metroGrid1);
        }
        private void LoadTableName(MetroGrid gridView)
        {
            gridView.DataSource = null;
            gridView.AutoGenerateColumns = false;
            List<ObjectPermission> lstObjectPermission = new List<ObjectPermission>();
            string select = @"SELECT rank() over(order by Id desc) as Stt,* from ObjectPermission";
            lstObjectPermission = db.Query<ObjectPermission>(select).ToList();
            if (lstObjectPermission != null)
            {
                gridView.DataSource = lstObjectPermission;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(UserManagement.AllowCreate("Users")==true)
            {
                frmCreateUser frmCreate = new frmCreateUser();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }
        public delegate void delgSetFormEnable(bool isEnable);
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if(UserManagement.AllowEdit("Users")==true)
            //{
            //    CustomUser user = null;
            //    int selectedrow = metroGrid1.CurrentRow.Index;
            //    //if (selectedrow == 0) return;
            //    user = (CustomUser)metroGrid1.Rows[selectedrow].DataBoundItem;
            //    if (user == null) return;
            //    frmEditUser frmEdit = new frmEditUser(user);
            //    frmEdit.Show();
            //    Form form = (frmPrimary)UtilityFunction.FindForm("frmPrimary");
            //    if (form == null) return;
            //    frmPrimary frmPrimary = (frmPrimary)form;
            //    delgSetFormEnable delg = new delgSetFormEnable(frmPrimary.SetEnable);
            //    delg(false);
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền chỉnh sửa");
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (UserManagement.AllowDelete("Users") == true)
            //{
            //    DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa người dùng này ?", "Cảnh báo", FlatMsgBox.Buttons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        CustomUser user = null;
            //        int selectedrow = metroGrid1.CurrentRow.Index;
            //        //if (selectedrow == 0) return;
            //        user = (CustomUser)metroGrid1.Rows[selectedrow].DataBoundItem;
            //        if (user == null) return;
            //        bool ok = Database.DeleteById<Users>("delete Users where Id = " + user.Id.ToString());
            //        if (ok == false)
            //        {
            //            FlatMsgBox.Show("Không thể xóa");
            //            return;
            //        }
            //        LoadTableName(this.isLoadAll, metroGrid1);
            //    }
            //    else return;
            //}
            //else
            //{
            //    FlatMsgBox.Show("Bạn không có quyền tạo mới");
            //}
        }
    }
}
