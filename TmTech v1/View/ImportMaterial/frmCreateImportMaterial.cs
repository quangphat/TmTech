using System;
using System.Collections.Generic;
using System.Linq;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using TmTech_v1.ValidateData;

namespace TmTech_v1.View
{
    public partial class frmCreateImportMaterial : ModernUI.Forms.MetroForm
    {
        private GridUtility gridutility;
        List<ImportMaterialDetail> listImportMaterialDetail = null;
        private ImportMaterial importMaterial;
        private ImportMaterialRequestDataBase _importMaterialRequestDataBase;
       
        public frmCreateImportMaterial(ImportMaterialRequestDataBase importMaterialRequestDataBase)
        {
            InitializeComponent();
            gridutility = new GridUtility(gridControl2);
            listImportMaterialDetail = new List<ImportMaterialDetail>();
            importMaterial = new ImportMaterial();
            _importMaterialRequestDataBase = importMaterialRequestDataBase;

        }

        private void frmCreateImportMaterial_Load(object sender, EventArgs e)
        {
            IList<Stock> lstStock = new List<Stock>();
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstStock = uow.StockRepository.GetAll();
                    //uow.ImportMaterialRepository.

                }
            }
            catch
            {

            }

       
            ComboboxUtility.BindData(cbbStock, lstStock, "StockName", "StockId");
            gridutility.BindingData(listImportMaterialDetail);
            labelNotify1.Text = string.Empty;
        }

        private List<ImportMaterialDetail> CreateListImportDetail(List<Model.Material> lst)
        {
            if (lst == null)
                return null;
            List<ImportMaterialDetail> result = new List<ImportMaterialDetail>();
            ImportMaterialDetail imde = null;
            foreach (var item in lst)
            {
                imde = new ImportMaterialDetail()
                {
                    MaterialId = item.MaterialId,

                    Material = item,
                    Price = item.Price
                };
                result.Add(imde);
            }
            return result;
        }

        private void AddRow(List<Model.Material> lstMaterial)
        {
            var listImportDetail = CreateListImportDetail(lstMaterial);
            if (listImportDetail == null)
                return;
            foreach (var item in listImportDetail)
            {

                ImportMaterialDetail record = listImportMaterialDetail.Find(x => x.MaterialId == item.MaterialId);
                if (record == null)

                {
                    listImportMaterialDetail.Add(item);
                }
                else
                {
                    record.Quantity += item.Quantity;
                }

            }
            gridView2.RefreshData();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            frmChooseMaterial obj = new frmChooseMaterial();
            obj.add = AddRow;
            obj.ShowDialog();
        }

        private void bootstrapButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddImportMaterial(object sender, EventArgs e)
        {
            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            Boolean isSuccess = false;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (AddMaterialImport(importMaterial, uow))
                {
                    if (AddMaterialDetail(listImportMaterialDetail, importMaterial, uow))
                    {
                        uow.Commit();
                        isSuccess = true;
                    }
                }
            }

            if(isSuccess)
            {
                _importMaterialRequestDataBase.Model = importMaterial;
                _importMaterialRequestDataBase.AddOrUpdateRow(_importMaterialRequestDataBase.Model, CRUD.Insert);
                this.Close();
            }
            else
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            } 
        }

        private bool AddMaterialDetail(List<ImportMaterialDetail> importMaterialDetail, ImportMaterial import, IUnitOfWork uow)
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
                return false;
              //  PopupMessage.Instance.LoadMessage(listerror.Value);
            }
              
            try

            {
                var quatity = 0;
                foreach (var item in importMaterialDetail)
                {
                    item.ImportId = import.ImportId;
                    quatity++;
                    import.Total += item.Thanhtien;
                    uow.ImportMaterialDetailRepository.Insert(item);
                }
                import.Quantity = quatity;
            }
            catch (Exception ex)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return false;
            }

            return true;
        }

        private bool AddMaterialImport(ImportMaterial importMaterial, IUnitOfWork uow)
        {


    
            importMaterial.Stock =cbbStock.SelectedItem!=null?cbbStock.SelectedItem as Stock : null;
            importMaterial.StockId = importMaterial.Stock != null ? importMaterial.Stock.StockId : 0;
            var dateCreate = dtpDateCreate.Value != null ? dtpDateCreate.Value : DateTime.Now;
            importMaterial.ImportCode = uow.ImportMaterialRepository.GetCode(importMaterial.StockId, dateCreate);

            importMaterial.CreateDate = dtpDateCreate.Value!=null?dtpDateCreate.Value:DateTime.Now;
            importMaterial.SetCreate();
            
            ImportMaterialValidate validate = new ImportMaterialValidate();
            var listError = validate.CheckValidate(importMaterial, uow);
            if (listError.Count>0)
            {
                /*PopupMessage.Instance.LoadMessage(listError)*/;
                return false;
            }
            try
            {
                uow.ImportMaterialRepository.Insert(importMaterial);
            }
            catch (Exception)
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                return false;
            }
            return true;
        }
    }
}
