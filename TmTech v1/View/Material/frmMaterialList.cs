using ModernUI.Forms;
using System.Collections.Generic;
using TmTech_v1.Utility;
using TmTech_v1.Interface;
using System;
using TmTech_v1.Model;
using System.Linq;
namespace TmTech_v1.View
{
    public partial class frmMaterialList : MetroForm
    {
        GridUtility gridUtility;
        Product m_Product;
        public frmMaterialList()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1, false, false,35);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridView1.RowHeight = 150;
        }
        public frmMaterialList(Product product)
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1, false, false, 35);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridView1.RowHeight = 100;
            m_Product = product;
        }
        private void frmMaterialList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            IList<Model.Material> lstMaterial;
            using(IUnitOfWork uow = new UnitOfWork())
            {
                if (m_Product == null)
                    lstMaterial = uow.MaterialRepository.All();
                else
                    lstMaterial = uow.MaterialRepository.GetMaterialByProductId(m_Product.ProductId);
                uow.Commit();
            }
            gridUtility.BindingData<Model.Material>( lstMaterial);
        }

        private void AddOrUpdateRow(Model.Material material, CRUD flag)
        {
            if (flag == CRUD.Insert)
            {
                gridUtility.AddNewRow<Model.Material>(material);
            }
            else
            {
                gridUtility.UpdateRow<Model.Material>(material);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Model.Material material = gridUtility.GetSelectedItem<Model.Material>() as Model.Material;
            if (material == null) return;
            frmEditMaterial frmEdit = new frmEditMaterial(material);
            frmEdit.ShowDialog();
            LoadGrid();
        }

        public delegate void delgAddToProduct(IList<Model.Material> lstMaterial,Product product);
        public delgAddToProduct AddToProduct;
        private void btnPickMaterial_Click(object sender, EventArgs e)
        {
            IList<Model.Material> lstMaterial = gridControl1.DataSource as IList<Model.Material>;
            IList<Model.Material> lstProductMaterial = lstMaterial.Where(p => p.MaterialQuantity >= 0).ToList();
            if(m_Product==null || lstProductMaterial==null)
            {
                Close();
            }
            if (AddToProduct != null)
                AddToProduct(lstProductMaterial, m_Product);
            Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }


    }
}
