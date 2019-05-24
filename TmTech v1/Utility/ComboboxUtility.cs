using ModernUI.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.ToolBoxCS;
namespace TmTech_v1.Utility
{
    public static class ComboboxUtility
    {
        public static void BindData<T>(MetroSearchComboBox combobox, List<T> lstSoucre, string displayMember, string valueMember) where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            combobox.DataSource = null;
            combobox.DataSource = lstSoucre;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public static void BindData<T>(ComboBox combobox, IList<T> lstSoucre, string displayMember, string valueMember) where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            combobox.DataSource = null;
            combobox.DataSource = lstSoucre;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public static void BindData<T>(MetroComboBox combobox, IList<T> lstSoucre, string displayMember, string valueMember) where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            combobox.DataSource = null;
            if (lstSoucre == null)
            {
                lstSoucre = new List<T>();
            }
            combobox.DataSource = lstSoucre;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
        public static void BindCompanyType(AutoCombobox cbb, List<CompanyType> lstCompanytype = null, int selectedvalue = 0)
        {
            if (lstCompanytype == null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstCompanytype = uow.CompanyTypeRepository.All();
                    uow.Commit();
                }
            }
            cbb.DataSource = null;
            cbb.DataSource = lstCompanytype;
            cbb.DisplayMember = "CompanyTypeName";
            cbb.ValueMember = "CompanyTypeId";
            cbb.SelectedValue = selectedvalue;
        }
        public static void BindCompanyClass(AutoCombobox cbb, List<CompanyClass> lstCompanyClass = null, int selectedvalue = 0)
        {
            if (lstCompanyClass == null)
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstCompanyClass = uow.CompanyRepository.AllClass();
                    uow.Commit();
                }
            }
            cbb.DataSource = null;
            cbb.DataSource = lstCompanyClass;
            cbb.DisplayMember = "CompanyClassCode";
            cbb.ValueMember = "CompanyClassId";
            cbb.SelectedValue = selectedvalue;
        }
        public static void BindSerie(MetroSearchComboBox combox, int subCateId, List<Series> lstBound = null)
        {
            IList<Series> lstSerie;
            if (lstBound != null)
                lstSerie = lstBound;
            else
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    lstSerie = subCateId > 0 ? uow.SeriesRepository.FindByCategory(subCateId) : uow.SeriesRepository.All();
                    uow.Commit();
                }
            }
            if (lstSerie == null) lstSerie = new List<Series>();

            combox.DataSource = null;
            combox.DataSource = lstSerie;
            combox.DisplayMember = "SerieName";
            combox.ValueMember = "SerieId";
        }
        public static void BindOrigin(MetroSearchComboBox combobox)
        {
            IList<Origin> lstOrigin;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstOrigin = uow.OriginRepository.All();
                uow.Commit();
            }
            if (lstOrigin != null)
            {
                combobox.DataSource = null;
                combobox.DataSource = lstOrigin;
                combobox.DisplayMember = "OriginName";
                combobox.ValueMember = "OriginId";
            }
        }
        public static void BindUnit(AutoSearchCombobox combobox)
        {
            IList<Unit> lstUnit;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstUnit = uow.UnitRepository.All();
                uow.Commit();
            }
            if (lstUnit != null)
            {
                combobox.DataSource = null;
                combobox.DataSource = lstUnit;
                combobox.DisplayMember = "UnitName";
                combobox.ValueMember = "UnitId";
            }
        }

        public static void BindCategory(MetroSearchComboBox combox, int selectvalue = 0)
        {
            IList<Category> lstCate;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCate = uow.CategoryRepository.All();
                uow.Commit();
            }
            if (lstCate != null)
            {
                combox.DataSource = null;
                combox.DataSource = lstCate;
                combox.DisplayMember = "CategoryName";
                combox.ValueMember = "CategoryId";
                combox.SelectedValue = selectvalue;
            }
        }

        public static void BindGroupPart(MetroSearchComboBox combox)
        {
            IList<GroupPart> lstCate;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCate = uow.GroupPartBaseRepository.All();
                uow.Commit();
            }
            if (lstCate != null)
            {
                combox.DataSource = null;
                lstCate.Add(new GroupPart { GroupPartId = 0, GroupPartName = "" });
                combox.DataSource = lstCate;
                combox.DisplayMember = "GroupPartName";
                combox.ValueMember = "GroupPartId";
            }
        }
        public static void BindStandard(MetroSearchComboBox cbb)
        {
            IList<ProductStandard> lstStandard;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstStandard = uow.ProductStandardRepository.All();
                uow.Commit();
            }
            if (lstStandard != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstStandard;
                cbb.DisplayMember = "StandardName";
                cbb.ValueMember = "StandardId";
            }
        }
        public static void BindClassProduct(MetroSearchComboBox cbb)
        {
            IList<ClassProduct> lstClassProduct;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstClassProduct = uow.ClassProductRepository.All();
                uow.Commit();
            }
            if (lstClassProduct != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstClassProduct;
                cbb.DisplayMember = "ClassProductName";
                cbb.ValueMember = "ClassProductId";
            }
        }
        public static void BindSupplier(MetroSearchComboBox cbb)
        {
            IList<Supplier> lstSupplier;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSupplier = uow.SupplierRepository.All();
                uow.Commit();
            }
            if (lstSupplier != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstSupplier;
                cbb.DisplayMember = "SupplierName";
                cbb.ValueMember = "SupplierId";
            }

        }
        public static void BindSupplierWidthALl(MetroSearchComboBox cbb)
        {
            IList<Supplier> lstSupplier;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSupplier = uow.SupplierRepository.All();
                uow.Commit();
            }
            if (lstSupplier != null)
            {
                cbb.DataSource = null;
                Supplier objAll = new Supplier { SupplierName = "Tất cả", SupplierId = 100 };
                lstSupplier.Add(objAll);
                cbb.DataSource = lstSupplier;
                cbb.DisplayMember = "SupplierName";
                cbb.ValueMember = "SupplierId";
            }

        }

        public static void BindGroupPartWidthALl(MetroSearchComboBox cbb)
        {
            IList<GroupPart> lstSupplier;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSupplier = uow.GroupPartBaseRepository.All();
                uow.Commit();
            }
            if (lstSupplier != null)
            {
                cbb.DataSource = null;
                GroupPart objAll = new GroupPart { GroupPartName = "Tất cả", GroupPartId = 0 };
                lstSupplier.Add(objAll);
                cbb.DataSource = lstSupplier;
                cbb.DisplayMember = "GroupPartName";
                cbb.ValueMember = "GroupPartId";


            }

        }


        public static void BindTypePartWidthALl(MetroSearchComboBox cbb, string groupPartId)
        {
            IList<TypePart> lstSupplier;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSupplier = groupPartId != "0" ? uow.TypePartBaseRepository.FindByGroupID(int.Parse(groupPartId)) : uow.TypePartBaseRepository.All();
                uow.Commit();
            }
            if (lstSupplier == null) 
                return;
            cbb.DataSource = null;
            cbb.DataSource = lstSupplier;
            TypePart objAll = new TypePart { TypePartName = "Tất cả", TypePartID = 0 };
            lstSupplier.Add(objAll);
            cbb.DisplayMember = "TypePartName";
            cbb.ValueMember = "TypePartID";
        }

        public static void BindSeriesParttWidthALl(MetroSearchComboBox cbb, string typePartID)
        {
            IList<SeriesPart> lstSupplier;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSupplier = typePartID == "0" ? uow.SeriesPartBaseRepository.All() : uow.SeriesPartBaseRepository.FindByTypeID(int.Parse(typePartID));

                uow.Commit();
            }
            if (lstSupplier == null) return;
            cbb.DataSource = null;
            SeriesPart objAll = new SeriesPart { SeriesPartName = "Tất cả", SeriesPartId = 0 };
            lstSupplier.Add(objAll);
            cbb.DataSource = lstSupplier;
            cbb.DisplayMember = "SeriesPartName";
            cbb.ValueMember = "SeriesPartId";
        }

        public static void BindParttWidthALl(MetroSearchComboBox cbb, string SeriesPartID)
        {
            IList<Part> lstSupplier;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                if (SeriesPartID == "0")
                {
                    lstSupplier = uow.PartBaseRepository.All();
                }
                else
                {
                    lstSupplier = uow.PartBaseRepository.FindBySeriesPartID(int.Parse(SeriesPartID));

                }

                uow.Commit();
            }
            if (lstSupplier == null) return;
            cbb.DataSource = null;
            Part objAll = new Part { PartName = "Tất cả", PartID = 0 };
            lstSupplier.Add(objAll);
            cbb.DataSource = lstSupplier;
            cbb.DisplayMember = "PartName";
            cbb.ValueMember = "PartID";
        }
        public static void BindSafety(MetroSearchComboBox cbb)
        {
            IList<ClassSafety> lstSafety;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstSafety = uow.ClassSafetyRepository.All();
                uow.Commit();
            }
            if (lstSafety == null) return;
            cbb.DataSource = null;
            cbb.DataSource = lstSafety;
            cbb.DisplayMember = "ClassSafetyName";
            cbb.ValueMember = "ClassSafetyId";
        }
        public static void BindLampType(MetroSearchComboBox cbb)
        {
            IList<LampTypes> lstLampType;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstLampType = uow.LampTypeRepository.All();
                uow.Commit();
            }
            if (lstLampType != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstLampType;
                cbb.DisplayMember = "LampTypeName";
                cbb.ValueMember = "LampTypeId";
            }
        }
        public static void BindCompany(ComboBox cbb)
        {
            IList<Company> lstCompany;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstCompany = uow.CompanyRepository.All();
                uow.Commit();
            }
            if (lstCompany != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstCompany;
                cbb.DisplayMember = "CompanyName";
                cbb.ValueMember = "CompanyId";
            }
        }
        public static void BindBank(ComboBox cbb)
        {
            IList<Bank> lstBank;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    lstBank = uow.BankBaseRepository.All(); ;
                    uow.Commit();
                }
                catch (System.Exception)
                {

                    return;
                }

            }
            if (lstBank != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstBank;
                cbb.DisplayMember = "BankName";
                cbb.ValueMember = "BankId";
            }
        }


        public static void BindQuotation(ComboBox cbb)
        {
            IList<Quotation> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.QuotationRepository.All();
                uow.Commit();
            }
            if (lstQuotation != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstQuotation;
                cbb.DisplayMember = "QuotationCode";
                cbb.ValueMember = "QuotationId";
            }
        }

        public static void BindStock(ComboBox cbb)
        {
            IList<Stock> lstStock;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstStock = uow.StockRepository.GetAll();
                uow.Commit();
            }
            if (lstStock != null)
            {
                cbb.DataSource = null;
                cbb.DataSource = lstStock;
                cbb.DisplayMember = "StockName";
                cbb.ValueMember = "StockId";
            }
        }

        public static void BindStatus(ComboBox cbb)
        {
            IList<ApproveStatusModel> lstStock = new List<ApproveStatusModel>();
            ApproveStatusModel obj = new ApproveStatusModel();
            obj.StatusId = 1;
            obj.StatusName = "Chờ xác nhận";
            lstStock.Add(obj);
            ApproveStatusModel obj1 = new ApproveStatusModel();
          
            obj1.StatusId = 2;
            obj1.StatusName = "Đã xác nhận";
            lstStock.Add(obj1);
            ApproveStatusModel obj2 = new ApproveStatusModel();
          
            obj2.StatusId = 3;
            obj2.StatusName = "Hủy bỏ";
            lstStock.Add(obj2);
            cbb.DataSource = null;
            cbb.DataSource = lstStock;
            cbb.DisplayMember = "StatusName";
            cbb.ValueMember = "StatusId";

        }


        public static void LoadDataClassCustormer(ComboBox cbx)
        {
            IList<CompanyClass> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.CompanyRepository.AllClass();
                uow.Commit();
            }
            if (lstQuotation != null)
            {
                cbx.DataSource = null;
                cbx.DataSource = lstQuotation;
                cbx.DisplayMember = "ClassCode";
                cbx.ValueMember = "ClassID";
            }
        }

        public static void LoadProductType(ComboBox cbx)
        {
            IList<ProductType> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.ProductTypeRepository.GetAll();
                uow.Commit();
            }
            if (lstQuotation != null)
            {
                cbx.DataSource = null;
                cbx.DataSource = lstQuotation;
                cbx.DisplayMember = "Name";
                cbx.ValueMember = "Code";
            }
        }


        public static void LoadLocation(ComboBox cbx)
        {
            IList<Location> lstQuotation;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstQuotation = uow.LocationRepository.GetAll();
                uow.Commit();
            }
            if (lstQuotation != null)
            {
                cbx.DataSource = null;
                cbx.DataSource = lstQuotation;
                cbx.DisplayMember = "Name";
                cbx.ValueMember = "Code";
            }
        }


        public static void BindRepositoryItemLookUpEdit<T>(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEdit, IList<T> list, string displayMember, string valueMember, string caption = "") where T : class
        {
            if (string.IsNullOrEmpty(displayMember) || string.IsNullOrWhiteSpace(displayMember)) return;
            lookUpEdit.DataSource = null;
            lookUpEdit.DataSource = list;
            lookUpEdit.DisplayMember = displayMember;
            lookUpEdit.ValueMember = valueMember;
            lookUpEdit.Columns.Clear();
            if (caption == "")
                lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember));
            else
                lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember, caption));
            lookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        public static void BindMaterialToRepositoryItemLookUpEdit(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEdit, IList<Model.Material> list,string IdColumnName,string displayMember,string ValueMember)
        {
            lookUpEdit.DataSource = null;
            lookUpEdit.DataSource = list;
            lookUpEdit.Columns.Clear();
            DevExpress.XtraEditors.Controls.LookUpColumnInfo IdColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            IdColumn.FieldName = "MaterialId";
            IdColumn.Caption = "Id";
            IdColumn.Visible = false;
            lookUpEdit.Columns.Add(IdColumn);
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterialCode", "Mã vật liệu"));
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaterialName", "Tên vật liệu"));
            lookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Supplier.SupplierName", "Nhà cung cấp"));
            lookUpEdit.DisplayMember = displayMember;
            lookUpEdit.ValueMember = ValueMember;
            lookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }
    }
}
