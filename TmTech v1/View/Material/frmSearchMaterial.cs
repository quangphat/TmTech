using System.Collections.Generic;
using TmTech_v1.Utility;
using TmTech_v1.Interface;
using System;
using TmTech_v1.Model;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.View
{
    public partial class frmSearchMaterial : UserControl
    {
        Product m_Product;
        IList<Model.Material> lstUpdate;
        GridUtility gridUtility;
        
        public frmSearchMaterial()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1, new MaterialContextMenu(), false, false, 35)
            {
                ColProductPicture = colPhoto,
                ColProductPicturePath = colImgPath
            };
            gridView1.RowHeight = 100;
            lstUpdate = new List<Model.Material>();
            gridUtility.SetRowColor();
            gridView1.BestFitColumns();
            labelNotify1.Text = string.Empty;
        }
        private void frmMaterialList_Load(object sender, EventArgs e)
        {
           
            ComboboxUtility.BindSupplier(cbbSupplier);
            btnSearch.PerformClick();
        }
       
        private void AddOrUpdateRow(Model.Material material, CRUD flag)
        {
            if (flag == CRUD.Insert)
            {

                lstUpdate.Add(material);
            }
            else
            {
                gridView1.RefreshData();
            }
        }

        private void Create()
        {
            Model.Material material = new Model.Material();
            MaterialRequestDataBase requeset = new MaterialRequestDataBase
            {
                IsEdit = false,
                Model = material,
                AddOrUpdateRow = AddOrUpdateRow
            };
            frmEditMaterial frmEdit = new frmEditMaterial(requeset);
            frmEdit.ShowDialog();
        }
              
        private void Delete()
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                Model.Material material = gridView1.GetRow(i) as Model.Material;
                if (material == null) return;
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.MaterialRepository.Remove(material);
                        uow.MaterialRepository.RemoveFromProduct(material.MaterialId);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                }
                catch
                {
                    lblNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                }
            }
        }
        private void Edit()
        {
            Model.Material material = gridUtility.GetSelectedItem<Model.Material>() as Model.Material;
            if (material == null) return;
            MaterialRequestDataBase requeset = new MaterialRequestDataBase
            {
                IsEdit = true,
                Model = material,
                gridview = gridView1
            };
            frmEditMaterial frmEdit = new frmEditMaterial(requeset);
            frmEdit.ShowDialog();
        }
        private void Search()
        {
            MaterialQuerry impo = new MaterialQuerry
            {
                _Token = txtSearch.Text,
                SupplierID = cbbSupplier.SelectedValue != null ? cbbSupplier.SelectedValue.ToString() : string.Empty,
                dtpFrom = dtpTimeFrom.EditValue != null ? (DateTime?)dtpTimeFrom.EditValue : null,
                dtpTo = dtpTimeTo.EditValue != null ? (DateTime?)dtpTimeTo.EditValue : null
            };
            MaterialSearch materialSearch = new MaterialSearch(impo);
            lstUpdate = materialSearch.GetAllSearch();
            gridUtility.BindingData(lstUpdate);
            gridView1.OptionsBehavior.Editable = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {



        }
        private void btnSearchMaterial(object sender, EventArgs e)
        {
            Search();
        }

        
    }
}
