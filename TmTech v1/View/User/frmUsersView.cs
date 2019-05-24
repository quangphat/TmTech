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
    public partial class frmUsersView : UserControl
    {
        IDbConnection db = DbTmTech.DbCon;
        GridUtility gridUtility;
        public bool isLoadAll;
        public frmUsersView()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public void LoadGrid()
        {
           
            IList<Users> lstUser;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstUser = uow.UsersRepository.All();
                uow.Commit();
            }
            if(lstUser!=null)
            {
                gridUtility.BindingData<Users>( lstUser);
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
            //    Users user = null;
            //    int selectedrow = metroGrid1.CurrentRow.Index;
            //    //if (selectedrow == 0) return;
            //    user = metroGrid1.Rows[selectedrow].DataBoundItem as Users;
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
            //        Users user = null;
            //        int selectedrow = metroGrid1.CurrentRow.Index;
            //        //if (selectedrow == 0) return;
            //        user = metroGrid1.Rows[selectedrow].DataBoundItem as Users;
            //        if (user == null) return;
            //        try
            //        {
            //            using (IUnitOfWork uow = new UnitOfWork())
            //            {
            //                uow.UsersRepository.Remove(user);
            //                uow.Commit();
                            
            //            }
            //            LoadGrid();
            //        }
            //        catch
            //        {
            //            FlatMsgBox.Show("Không thành công");
            //            return;
            //        }
                    
            //    }
            //    else return;
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
