using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;

namespace TmTech_v1.View
{
    public partial class frmProductTypeMain : UserControl
    {
        GridUtility gridUtility;

        public frmProductTypeMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmProductTypeMain_Load(object sender, EventArgs e)
        {
            loadProductTypeDB();
            labelNotify1.Text = "";
        }

        private void loadProductTypeDB()
        {
            IList<ProductType> lstProductType = new List<ProductType>();
            using (IUnitOfWork uow = new UnitOfWork())
            {

                lstProductType = uow.ProductTypeRepository.GetAll();
                uow.Commit();
            }
            gridUtility.BindingData( lstProductType);

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateProductType fU = new frmCreateProductType();
            fU.addNewProductType = AddOrUpdate;
            fU.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void AddOrUpdate(ProductType unit,CRUD crud)
        {
            if(crud== CRUD.Insert)
            {
                gridUtility.AddNewRow(unit);
            }
            if (crud == CRUD.Update)
            {
                gridUtility.UpdateRow( unit);
            }
            gridControl1.RefreshDataSource();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductType unit = gridUtility.GetSelectedItem<ProductType>();
            if (unit == null) return;
            frmEditProductType fEU = new frmEditProductType(unit);
            fEU.UpdateNewProductType = AddOrUpdate;
            fEU.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows()[0];
            ProductType ProductType = gridUtility.GetSelectedItem<ProductType>();
            if (ProductType == null) return;
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.ProductTypeRepository.Delete(ProductType);
                        uow.Commit();
                    }
                }
                catch
                {
                    labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                    return;
                }
                gridView1.DeleteRow(i);
            }
        }
    }
}
