using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech_v1.Utility;
using DevExpress.XtraGrid.Views.Grid;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using DevExpress.XtraEditors;
using TmTech.Resource;
using DevExpress.XtraGrid;
using TmTech_v1.ValidateData;
using TmTech_v1.ToolBoxCS;

namespace TmTech_v1.View
{
    public partial class frmImportMaterialDetail : UserControl
    {
        private GridUtility gridutility;
        private ImportMaterial import;
        private PopupMessage _PopupMessage = new PopupMessage();

        IList<ImportMaterialDetail> lstDetail = new List<ImportMaterialDetail>();

        public frmImportMaterialDetail(ImportMaterial import)
        {
            InitializeComponent();

            this.import = import;
            gridutility = new GridUtility(gridControl2);
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridView2.RowDeleting += GridView2_RowDeleting;
            labelNotify1.Text = string.Empty;
            ComboboxUtility.BindStock(cboStock);
            ComboboxUtility.BindStatus(cboStatus);
            CoverObjectUtility.SetAutoBindingData(this, import);
            cbbMaterialCode.EditValueChanged += cbbMaterialCode_EditValueChanged;
            //gridView2.FocusedRowHandle = -1;
        }
        private void GridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            var rowdelete = gridView2.GetRow(e.RowHandle) as ImportMaterialDetail;
            if (rowdelete == null)
                return;
            if (rowdelete.ImportDetailId != Guid.Empty) 
            {
              

            }
        }
        private void GridControl2_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
            }
        }
        private void frmImportMaterialDetail_Load(object sender, EventArgs e)
        {
            IList<Model.Material> lstMat = new List<Model.Material>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstMat = uow.MaterialRepository.GetAllForComboBox();
                    lstDetail = uow.ImportMaterialDetailRepository.All(import.ImportId);
                    uow.Commit();
                }
                ComboboxUtility.BindMaterialToRepositoryItemLookUpEdit(cbbMaterialCode, lstMat, "MaterialId", "MaterialCode", "MaterialCode");
                gridutility.BindingData(lstDetail);
                LoadData(import);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadData(ImportMaterial _import)
        {
            CoverObjectUtility.SetAutoBindingData(panel5, _import);
            //var Status = cboStatus.SelectedItem as ApproveStatusModel;
            bool isEditImportMaterial = false;
            gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            if (_import.ApproveStatusId == 2)
            {
                gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gridView2.OptionsBehavior.Editable = false;
                isEditImportMaterial = false;
            }
            else
            {
                gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gridView2.OptionsBehavior.Editable = true;
               
                isEditImportMaterial = true;
            }
            cboStock.Enabled = isEditImportMaterial;
            cboStatus.Enabled = isEditImportMaterial;
            btnSave.Visible = isEditImportMaterial;
            btnApprove.Visible = isEditImportMaterial;
        }
        private int selectindex = -1;
        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            gridutility.SetRowColor();
            int currentIndex = gridView2.GetSelectedRows().FirstOrDefault();
            if (selectindex == currentIndex)
                return;
            try
            {

                var imagePath = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["Material.PhotoPath"]);
                if (imagePath != null)
                {
                    PictureUtility.BindImage(ptPhoto, gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns["Material.PhotoPath"]).ToString());
                    selectindex = currentIndex;
                }
                else
                {
                    label6.Hide();
                }

            }
            catch (Exception)
            {

                return;
            }
        }
        private void cbbMaterialCode_EditValueChanged(object sender, EventArgs e)
        {
            Model.Material mat = (sender as LookUpEdit).GetSelectedDataRow() as Model.Material;
            ImportMaterialDetail detail = new ImportMaterialDetail();
            ImportMaterialDetail exists = lstDetail.Where(p => p.MaterialId == mat.MaterialId).FirstOrDefault();
            int i = gridView2.FocusedRowHandle;
            ImportMaterialDetail selectedrow = gridView2.GetRow(i) as ImportMaterialDetail;
            detail.Material = mat;
            detail.MaterialId = mat.MaterialId;
            detail.Price = mat.Price;
            detail.ImportId = import.ImportId;
            detail.Quantity=1;
            if (selectedrow == null || (selectedrow.MaterialId == 0) || selectedrow.MaterialId == null)
            {
                gridView2.DeleteRow(i);
                if (exists == null)
                {
                    //gridutility.AddNewRow(detail);
                    lstDetail.Add(detail);
                }
                else
                {
                    exists.Quantity += 1;
                    
                }
            }
            else
            {
                gridutility.UpdateRow(detail);
            }
            gridView2.RefreshData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            FormUtility.OpenTabByWinFrm(typeof(frmImportMaterial).Name);
            FormUtility.CloseTabByWinFrm(this);
        }
        private void Save()
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                CoverObjectUtility.GetAutoBindingData(panel5, import);
                import.Quantity = lstDetail.Sum(p => p.Quantity);
                import.Total = lstDetail.Sum(p => p.Thanhtien);
                
                foreach (ImportMaterialDetail detail in lstDetail)
                {
                    if (detail.ImportDetailId == Guid.Empty)
                    {
                        uow.ImportMaterialDetailRepository.Insert(detail);
                    }
                    else
                    {
                        uow.ImportMaterialDetailRepository.Edit(detail);
                    }
                }
                uow.ImportMaterialRepository.Edit(import);
                uow.Commit();
            }
        }
        private bool AddMaterialDeatail(List<ImportMaterialDetail> importMaterialDetail, ImportMaterial import, IUnitOfWork uow)
        {
            if (importMaterialDetail == null)
                return false;
            ImportMaterialDetailValidate importDetail = new ImportMaterialDetailValidate();
            Dictionary<string, List<ErrorData>> lstResult = new Dictionary<string, List<ErrorData>>();
            foreach (var item in importMaterialDetail)
            {
                var result = importDetail.CheckValidate(item);
                if (result != null)
                    lstResult.Add(item.Material.MaterialName, result);
            }
            if (lstResult.Any())
            {
                var listerror = lstResult.FirstOrDefault();
                if (_PopupMessage == null)
                {
                    _PopupMessage = new PopupMessage();
                }
                _PopupMessage.LoadMessage(listerror.Value);
                return false;
            }
            try
            {
                foreach (var item in importMaterialDetail)
                {
                    item.ImportId = import.ImportId;
                    import.Total += item.Thanhtien;
                    uow.ImportMaterialDetailRepository.Insert(item);
                }
            }
            catch (Exception ex)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return false;
            }
            return true;
        }
        private bool UpdateMaterialDetailImport(List<ImportMaterialDetail> importMaterialDetail, ImportMaterial import, IUnitOfWork uow)
        {
            if (importMaterialDetail == null)
                return false;
            ImportMaterialDetailValidate importDetail = new ImportMaterialDetailValidate();
            Dictionary<string, List<ErrorData>> lstResult = new Dictionary<string, List<ErrorData>>();
            foreach (var item in importMaterialDetail)
            {
                var result = importDetail.CheckValidateUpdate(item, uow);
                if (result.Count > 0)
                    lstResult.Add(item.Material.MaterialName, result);
            }
            if (lstResult.Count > 0)
            {
                var listerror = lstResult.FirstOrDefault();
                if (_PopupMessage == null)
                {
                    _PopupMessage = new PopupMessage();

                }
                _PopupMessage.LoadMessage(listerror.Value);
            }
            try
            {
                foreach (var item in importMaterialDetail)
                {

                    uow.ImportMaterialDetailRepository.Edit(item);
                }
            }
            catch (Exception)
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return false;
            }
            return true;
        }
        private bool DeleteDetailImport(List<ImportMaterialDetail> importMaterialDetail, ImportMaterial import, IUnitOfWork uow)
        {
            if (importMaterialDetail == null)
                return false;
            ImportMaterialDetailValidate importDetail = new ImportMaterialDetailValidate();
            try
            {
                foreach (var item in importMaterialDetail)
                {
                    uow.ImportMaterialDetailRepository.Delete(item);
                }
            }
            catch (Exception)
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return false;
            }
            return true;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            DialogResult result = FormUtility.MsgApprove();
            if (result == System.Windows.Forms.DialogResult.No) return;
            if (import.ApproveStatusId == (int)ApproveStatus.Approved)
            {
                labelNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return;
            }
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    import.ApproveStatusId = (int)ApproveStatus.Approved;
                    import.ApproveBy = UserManagement.UserSession.UserName;
                    import.ApproveDate = DateTime.Now;
                    uow.ImportMaterialRepository.Edit(import);
                    LogUtility.WriteLog(import.ImportCode, import.ApproveStatusId, uow);
                    uow.Commit();
                }
                FormUtility.OpenTabByWinFrm(typeof(frmImportMaterial).Name);
                FormUtility.CloseTabByWinFrm(this);

            }
            catch
            {
                labelNotify1.SetText(UI.itemwasapproved, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
           
        }

        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            btnApprove_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormUtility.CloseCurrentTab();
            FormUtility.OpenTabByWinFrm(typeof(frmImportMaterial).Name);
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
