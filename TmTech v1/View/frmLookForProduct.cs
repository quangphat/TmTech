using DevExpress.XtraGrid;
using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmLookForProduct : MetroForm
    {
        GridUtility gridUtility;
        public frmLookForProduct()
        {
            InitializeComponent();
            Select();
            txtSearch.Select();
            gridUtility = new GridUtility(gridControl1);
            metroProgressBar1.Visible = false;
            lblMessage.Text = string.Empty;
        }

        public delegate void delgEnableForm(bool enable);
        public delgEnableForm EnableForm;
        public delegate void delgAddProductToGrid(IList<CustomModel.CustomProduct> lstProduct);
        public delgAddProductToGrid AddProductToGrid;
        private void Search(GridControl grid, string searchStr = "")
        {
            List<CustomModel.CustomProduct> lstProduct = new List<CustomModel.CustomProduct>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstProduct = uow.ProductRepository.FindToCustom(searchStr);
                    uow.Commit();
                }
                if (lstProduct != null)
                {
                    setDataSource(lstProduct);
                }
            }
            catch
            {
                if (lstProduct != null)
                {
                    setDataSource(lstProduct);
                }
            }
        }
        internal delegate void SetDataSourceDelegate(List<CustomModel.CustomProduct> lstProduct);
        private void setDataSource(List<CustomModel.CustomProduct> lstProduct)
        {
            // Invoke method if required:
            if (InvokeRequired)
            {
                Invoke(new SetDataSourceDelegate(setDataSource), lstProduct);
            }
            else
            {
                if (lstProduct == null || lstProduct.Count == 0)
                {
                    lblMessage.Text = UI.productnotfound;
                    lblMessage.ForeColor = Color.OrangeRed;
                    Select();
                    txtSearch.Select();
                    txtSearch.Focus();
                }
                else
                {
                    lblMessage.Text = string.Empty;
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = lstProduct;
                    gridView1.FocusedRowHandle = 0;
                    gridView1.FocusedColumn = colSoluong;
                    gridView1.ShowEditor();
                }
            }
        }
        private void frmLookForProduct_Load(object sender, EventArgs e)
        {
            bgwLoadProduct = new BackgroundWorker();
            bgwLoadProduct.DoWork += bgwLoadProduct_DoWork;
            bgwLoadProduct.RunWorkerCompleted += bgwLoadProduct_RunWorkerCompleted;
        }

        private void bgwLoadProduct_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressBar1.Visible = false;
            txtSearch.Enabled = true;
        }

        private void bgwLoadProduct_DoWork(object sender, DoWorkEventArgs e)
        {
            Search(gridControl1, txtSearch.Text);
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            metroProgressBar1.Value = 0;
            metroProgressBar1.Visible = true;
            txtSearch.Enabled = false;
            bgwLoadProduct.RunWorkerAsync();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (bgwLoadProduct.IsBusy == true)
                    return;
                else
                {
                    metroProgressBar1.Value = 0;
                    metroProgressBar1.Visible = true;
                    txtSearch.Enabled = false;
                    bgwLoadProduct.RunWorkerAsync();
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            IList<CustomModel.CustomProduct> lstLookProduct = new List<CustomModel.CustomProduct>();
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                CustomModel.CustomProduct lookProduct = gridView1.GetRow(i) as CustomModel.CustomProduct;
                if (lookProduct.Quantity != 0)
                {
                    if (lookProduct.POPrice == 0)
                        lookProduct.POPrice = lookProduct.BasePrice;
                    lstLookProduct.Add(lookProduct);
                }     
            }
            if (lstLookProduct != null && AddProductToGrid != null)
            {
                    AddProductToGrid(lstLookProduct);
            }
            if (EnableForm != null)
                EnableForm(true);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (EnableForm != null)
                EnableForm(true);
            Close();
        }
    }
}
