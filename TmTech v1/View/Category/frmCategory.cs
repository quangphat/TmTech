using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Utility;
using FlatMessageBox;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.View
{
    public partial class Lstcategory : UserControl
    {
        GridUtility gridUtility;
        public bool isLoadAll;
        public Lstcategory()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            gridUtility = new GridUtility(gridControl1);
        }

        private void Lstcategory_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            IList<Category> lstCategory;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                lstCategory = uow.CategoryRepository.All();
                uow.Commit();
            }
            if(lstCategory!=null)
            {
                gridUtility.BindingData<Category>( lstCategory);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (UserManagement.AllowCreate("Category") == true)
            {
                frmCreateCategory frmCreate = new frmCreateCategory();
                frmCreate.Show();
            }
            else
            {
                FlatMsgBox.Show("Bạn không có quyền tạo mới");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (UserManagement.AllowDelete("Category") == true)
            //{
            //    DialogResult result = FlatMsgBox.Show("Bạn có chắc muốn xóa nhóm này này ?", "Cảnh báo", FlatMsgBox.Buttons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        TmTech_v1.Model.Category cate = null;

            //        int selectedrow = metroGrid1.CurrentCell.RowIndex;
            //        //if (selectedrow == 0) return;
            //        cate = (TmTech_v1.Model.Category)metroGrid1.Rows[selectedrow].DataBoundItem as TmTech_v1.Model.Category;
            //        if (cate == null) return;
            //        bool ok = Database.DeleteById<TmTech_v1.Model.Category>("delete Category where Id = " + cate.Id);
            //        if (ok == false)
            //        {
            //            FlatMsgBox.Show("Không thể xóa");
            //            return;
            //        }
            //        metroGrid1.Rows.Remove(metroGrid1.Rows[selectedrow]);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category category = gridUtility.GetSelectedItem<Category>();
            if(category!=null)
            {
                frmEditCategory frmEdit = new frmEditCategory(category);
                frmEdit.Show();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

    }
}
