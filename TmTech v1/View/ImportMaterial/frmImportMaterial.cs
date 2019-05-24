using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Model;
using TmTech_v1.Interface;
using TmTech_v1.Utility;
using TmTech.Resource;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.View
{
    public partial class frmImportMaterial : UserControl
    {
        private GridUtility gridutility;
        IList<ImportMaterial> lisImportMaterial;
        private ImportMaterialBaseSearch _importMaterialBaseSearch;
        public delegate void delgAddTab(UserControl uCtrl);
        public delgAddTab AddTab;
        frmImportMaterialDetail frmEdit;

        private bool isShowEdit = false;
        public frmImportMaterial()
        {
            InitializeComponent();
            gridutility = new GridUtility(gridControl1);
            FormUtility.FormatForm(this);
            this.Anchor = AnchorStyles.None;
            panel5.Anchor = AnchorStyles.None;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowCellStyle +=gridView1_RowCellStyle;
            lisImportMaterial = new List<ImportMaterial>();
            gridControl1.UseEmbeddedNavigator = true;
            labelNotify1.Text = string.Empty;



        }
        private void frmImportMaterial_Load(object sender, EventArgs e)
        {
            ComboboxUtility.BindStock(autoSearchCombobox1);
            gridutility.BindingData(lisImportMaterial);
            DateTime firstDay = DateTime.Today.AddDays(1 - DateTime.Today.Day);
            DateTime lastDayFilter = firstDay.AddMonths(1).AddDays(-1);
            dtpTimeFrom.EditValue = firstDay;
            dtpTimeTo.EditValue = lastDayFilter;
            btnSearch.PerformClick();

         
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ImportMaterial material = new Model.ImportMaterial();

            ImportMaterialRequestDataBase requeset = new ImportMaterialRequestDataBase
            {
                IsEdit = false,
                Model = material,
                AddOrUpdateRow = AddOrUpdateRow

            };
            frmCreateImportMaterial frmEdit = new frmCreateImportMaterial(requeset);
            frmEdit.ShowDialog();
        }


        private void AddOrUpdateRow(Model.ImportMaterial model, CRUD flag)
        {
            if (flag == CRUD.Insert)
            {
                if (lisImportMaterial == null)
                    lisImportMaterial = new List<ImportMaterial>();
                lisImportMaterial.Add(model);
                gridView1.RefreshData();
            }
            else
            {
                gridView1.RefreshData();
            }
                
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            Search();
        }
        private void Search()
        {
            ImportMaritalQuerry impo = new ImportMaritalQuerry
            {
                _Token = txtSearch.Text,
                Stock = autoSearchCombobox1.SelectedValue != null ? autoSearchCombobox1.SelectedValue.ToString() : string.Empty,
                dtpFrom = dtpTimeFrom.EditValue != null ? (DateTime?)dtpTimeFrom.EditValue : null,
                dtpTo = dtpTimeTo.EditValue != null ? (DateTime?)dtpTimeTo.EditValue : null
            };
            _importMaterialBaseSearch = new ImportMaterialBaseSearch(impo);
            lisImportMaterial = _importMaterialBaseSearch.GetAllSearch();
            gridutility.BindingData(lisImportMaterial);
            if (lisImportMaterial.Count > 0)
            {
                isShowEdit = true;
            }
            else
            {
                isShowEdit = false;
            }
            btnDelete.Visible = isShowEdit;
            btnEdit.Visible = isShowEdit;
        }
        private void EditMaterialDetail(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            gridutility.DrawStatusColor(sender, e, colStatusImport, colImportCode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = FormUtility.MsgDelete();
            if (result == DialogResult.Yes)
            {
                int i = gridView1.GetSelectedRows().FirstOrDefault();
                ImportMaterial importMatetialDelete = gridView1.GetRow(i) as ImportMaterial;
                if (importMatetialDelete != null)
                {
                    if (importMatetialDelete.ApproveStatusId == (int)ApproveStatus.Approved)
                    {
                        labelNotify1.SetText(UI.itemwasapproved, LabelNotify.EnumStatus.Failed, 5000);
                        return;
                    }
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.ImportMaterialRepository.Delete(importMatetialDelete);
                        uow.Commit();
                    }
                    gridView1.DeleteRow(i);
                    if (lisImportMaterial.Contains(importMatetialDelete))
                        lisImportMaterial.Remove(importMatetialDelete);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            Model.ImportMaterial material = gridutility.GetSelectedItem<Model.ImportMaterial>() as Model.ImportMaterial;
            if (material == null)
                return;
            if (frmEdit == null)
            {
                frmEdit = new frmImportMaterialDetail(material);
            }
            else
            {
                frmEdit.LoadData(material);
            }
            AddTab(frmEdit);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(frmEdit !=null )
            {
                FormUtility.CloseTabByWinFrm(frmEdit);
            }
            FormUtility.CloseCurrentTab();
        }
    }
}
