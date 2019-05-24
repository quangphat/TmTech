using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Utility;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using FlatMessageBox;

namespace TmTech_v1.View
{
    public partial class frmProductLeftView : UserControl
    {
        frmPrimary m_frmPrimary;
        GridUtility gridUtility;
        
        public frmProductLeftView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            m_frmPrimary = Application.OpenForms["frmPrimary"] as frmPrimary;
            gridUtility = new GridUtility(gridControl1);
        }
        private void itemProduct_Click(object sender, EventArgs e)
        {
            m_frmPrimary.itemProductClick();
        }

        private void itemProductGroup_Click(object sender, EventArgs e)
        {
            m_frmPrimary.itemProductGroupClick();
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

        private void frmProductLeftView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            IList<Category> lstCategory;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCategory = uow.CategoryRepository.All();
                uow.Commit();
            }
            if (lstCategory != null)
            {
                gridUtility.BindingData<Category>( lstCategory);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category category = gridUtility.GetSelectedItem<Category>();
            if (category != null)
            {
                frmEditCategory frmEdit = new frmEditCategory(category);
                frmEdit.Show();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                Category cate = gridView1.GetRow(i) as Category;
                if (cate == null) return;
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.CategoryRepository.Remove(cate);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                catch
                {
                }
            }
        }

        public void addNewRow(Category category)
        {
            if (category == null) return;
            gridUtility.AddNewRow<Category>( category);
        }
    }
}
