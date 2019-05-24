using ModernUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
namespace TmTech_v1.View
{
    public partial class frmProductMaterial : MetroForm
    {
        Product m_Product;
        GridUtility gridUtility;
        public frmProductMaterial(Product product)
        {
            InitializeComponent();
            m_Product = product;
            gridUtility = new GridUtility(gridControl1, false, false, 35);
            FormUtility.FormatForm(this);
            gridUtility.ColProductPicture = colPhoto;
            gridUtility.ColProductPicturePath = colImgPath;
            gridView1.RowHeight = 100;
        }
        public void LoadGrid()
        {
            IList<Model.Material> lstMaterial;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstMaterial = uow.MaterialRepository.GetMaterialByProductId(m_Product.ProductId);
                uow.Commit();
            }
            IList<Model.Material> lstProductMaterial = new List<Model.Material>();
            if(lstMaterial!=null)
            {
                lstProductMaterial = lstMaterial.Where(p => p.MaterialQuantity > 0).ToList();
            }
            gridUtility.BindingData<Model.Material>( lstProductMaterial);
            searchLookUpEdit1.Properties.DataSource = lstMaterial;
        }

        private void frmProductMaterial_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            gridUtility.SetRowColor();
        }

        private void searchLookUpEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value==null)   
                e.DisplayText = "Find material";
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == searchLookUpEdit1View.FocusedRowHandle)
            {
                searchLookUpEdit1View.Appearance.FocusedRow.BackColor = ((int)TmTechColor.GridviewRow).ToColor();
                searchLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = "1";
            btnAdd.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Material material = searchLookUpEdit1.EditValue as Model.Material;
            if (material == null) return;
            material.MaterialQuantity = Convert.ToInt32(txtQuantity.Text);
            material.ProductId = m_Product.ProductId;
            IList<Model.Material> lstMaterial = gridControl1.DataSource as IList<Model.Material>;
            ProductMaterial productmaterial=null;
            Model.Material exists = null;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    if (lstMaterial != null)
                    {
                        exists = lstMaterial.Where(p => p.MaterialId == material.MaterialId && p.ProductId == material.ProductId).FirstOrDefault();
                    }
                    if (exists != null)
                    {
                        exists.MaterialQuantity += material.MaterialQuantity;
                        productmaterial = new ProductMaterial();
                        productmaterial.ProductId = m_Product.ProductId;
                        productmaterial.MaterialId = exists.MaterialId;
                        productmaterial.MaterialQuantity = exists.MaterialQuantity;
                        uow.MaterialRepository.UpdateProductMaterial(productmaterial);
                    }
                    else
                    {
                        productmaterial = new ProductMaterial();
                        productmaterial.ProductId = m_Product.ProductId;
                        productmaterial.MaterialId = material.MaterialId;
                        productmaterial.MaterialQuantity = material.MaterialQuantity;
                        uow.MaterialRepository.AddProductMaterial(productmaterial);
                    }
                    uow.Commit();
                }
                gridUtility.AddNewRow<Model.Material>(material);
                labelNotify1.SetText(UI.success, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
            catch
            {
                labelNotify1.SetText(UI.failed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = gridView1.GetSelectedRows().FirstOrDefault();
            Model.Material material = gridView1.GetRow(i) as Model.Material;
            if (material == null) return;
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.MaterialRepository.RemoveFromProduct(material.MaterialId, m_Product.ProductId);
                    uow.Commit();
                }
                gridView1.DeleteRow(i);
            }
            catch
            { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IList<Model.Material> lstMaterial = gridControl1.DataSource as IList<Model.Material>;
            if (lstMaterial == null) return;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                foreach (Model.Material material in lstMaterial)
                {
                    ProductMaterial prdMaterial = new ProductMaterial();
                    prdMaterial.MaterialId = material.MaterialId;
                    prdMaterial.ProductId = m_Product.ProductId;
                    prdMaterial.MaterialQuantity = material.MaterialQuantity;
                    uow.MaterialRepository.UpdateProductMaterial(prdMaterial);
                    uow.Commit();
                }
            }
        }
    }
}
