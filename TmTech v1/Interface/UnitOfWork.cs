using System;
using System.Data;
using TmTech_v1.Repository;
using TmTech_v1.Utility;

namespace TmTech_v1.Interface
{
    public class UnitOfWork : IUnitOfWork
    {
        private IBankCompanyBaseRepository _bankCompanyBaseRepository;
        private IBankBaseRepository _bankBaseRepository;
        private IBrankBankBaseRepository _brankBankBaseRepository;
        private ICategoryRepository _categoryRepository;
        private IClassProductRepository _classProductRepository;
        private IClassSafetyRepository _classSafetyRepository;
        private ICompanyRepository _companyRepository1;
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private ICurrencyUnitRepository _currencyUnitRepository;
        private IDepartmentRepository _departmentRepository;
        private IDeputyRepository _deputyRepository;
        private bool _disposed;
        private IGridViewRepository _gridviewRepository;
        private IGroupPartBaseRepository _groupPartBaseRepository;
        private IObjectCoverRepository _objectCoverRepository;
        private IGroupSupplierRepository _iGroupSupplierRepository;
        private ILampTypeRepository _lampTypeRepository;
        private IMaterialRepository _materialRepository;
        private IOriginRepository _originRepository;
        private IPartBaseRepository _partBaseRepository;
        private IPermissionsRepository _permissionsRepository;
        private IPlanningDetailRepository _planningDetailRepository;
        private IPlanningRepository _planningRepository;
        private IPoDetailRepository _poDetailRepository;
        private IPoRepository _poRepository;
        private IProductPriceRepository _productPriceRepository;
        private IProductRepository _productRepository;
        private IStaffRepository _StaffRepository;
        private IProductStandardRepository _productStandardRepository;
        private IQuotationDetailRepository _quotationDetailRepository;
        private IQuotationRepository _quotationRepository;
        private ISeriesPartBaseRepository _seriesPartBaseRepository;
        private ISeriesRepository _seriesRepository;
        private ISourcingBaseRepository _sourcingBaseRepository;
        private IStaffPositionRepository _staffPositionReposity;
        private IProductLineRepository _subCategoryRepository;
        private ISupplierRepository _supplierRepository;
        private ITypePartBaseRepository _typePartBaseRepository;
        private IUnitRepository _unitRepository;
        private IUserGroupRepository _userGroupRepository;
        private IUsersRepository _usersRepository;
        private IUserTypeRepository _userTypeRepository;
        private ISubSupplierRepository _SubSupplierRepository;
        private IDebtRepository _debtRepository;
        private INoteProjectDetailBaseRepository _noteProjectDetailBaseRepository;
        private IIncomeExpenseRepository _incomeExpenseRepository;
        private IPaymentMethodRepository _paymentMethodRepository;
        private IDeliveryRepository _deliveryRepository;
        private IPaymentRepository _paymentRepository;
        private ICompanyTypeRepository _companyTypeRepository;
        private IProductPictureRepository _productPictureRepository;
        private IRequestSentRepository _requestSentRepository;
        private IImportMaterialDetailRepository _importMaterialDetailRepository;
        private IImportMaterialRepository _importMaterialRepository;
        private ILocationRepositor ilocationRepositor;
        private ISuggestionRepository _suggestionRepository;
        private IStockMaterialRepository _stockMaterialRepository;
        public IProductPictureRepository ProductPictureRepository
        {
            get { return _productPictureRepository ?? (_productPictureRepository = new ProductPictureRepository(_transaction)); }
        }
        public IDeliveryRepository DeliveryRepository
        {
            get { return _deliveryRepository ?? (_deliveryRepository = new DeliveryRepository(_transaction)); }
        }
        private IDebtDetailRepository _debtDetailRepository;
        public IDebtDetailRepository DebtDetailRepository
        {
            get { return _debtDetailRepository ?? (_debtDetailRepository = new DebtDetailRepository(_transaction)); }
        }
        private IApproveLogRepository _approveLogRepository;
        public IApproveLogRepository ApproveLogRepository
        {
            get { return _approveLogRepository ?? (_approveLogRepository = new ApproveLogRepository(_transaction)); }
        }
        private IProjectBaseRepository _projectBaseRepository;
        private IRequestPaymentBaseRepository _requestPaymentBaseRepository;

        public UnitOfWork()
        {
            try
            {
                _connection = DbTmTech.Create();
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception)
            {
                return;
            }
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }
                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void ResetRepositories()
        {
            _productRepository = null;
            _categoryRepository = null;
            _StaffRepository = null;
            _companyRepository1 = null;
            _deputyRepository = null;
            _usersRepository = null;
            _userTypeRepository = null;
            _userGroupRepository = null;
            _permissionsRepository = null;
            _poRepository = null;
            _poDetailRepository = null;
            _quotationDetailRepository = null;
            _quotationRepository = null;
            _companyRepository1 = null;
            _deputyRepository = null;
            _subCategoryRepository = null;
            _seriesRepository = null;
            _productStandardRepository = null;
            _classProductRepository = null;
            _classSafetyRepository = null;
            _lampTypeRepository = null;
            _bankBaseRepository = null;
            _materialRepository = null;
            _supplierRepository = null;
            _planningRepository = null;
            _planningDetailRepository = null;
            _originRepository = null;
            _unitRepository = null;
            _gridviewRepository = null;
            _deliveryRepository = null;
            _paymentMethodRepository = null;
            _gridviewRepository = null;
            _projectBaseRepository = null;
            _requestPaymentBaseRepository = null;
            _paymentRepository = null;
            _approveLogRepository = null;
            _debtDetailRepository = null;
            _requestSentRepository = null;
            _suggestionRepository = null;

        }

        public IProductTypeRepository ProductTypeRepository { get; private set; }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }
        public IUnitRepository UnitRepository
        {
            get { return _unitRepository ?? (_unitRepository = new UnitRepository(_transaction)); }
        }
        public IGridViewRepository GridviewRepository
        {
            get { return _gridviewRepository ?? (_gridviewRepository = new GridviewRepository(_transaction)); }
        }
        public IOriginRepository OriginRepository
        {
            get { return _originRepository ?? (_originRepository = new OriginRepository(_transaction)); }
        }
        public IPlanningRepository PlanningRepository
        {
            get { return _planningRepository ?? (_planningRepository = new PlanningRepository(_transaction)); }
        }
        public IPlanningDetailRepository PlanningDetailRepository
        {
            get { return _planningDetailRepository ?? (_planningDetailRepository = new PlanningDetailRepository(_transaction)); }
        }
        public ISupplierRepository SupplierRepository
        {
            get { return _supplierRepository ?? (_supplierRepository = new SupplierRepository(_transaction)); }
        }
        public IProductLineRepository ProductLineRepository
        {
            get { return _subCategoryRepository ?? (_subCategoryRepository = new ProductLineRepository(_transaction)); }
        }
        public IProductPriceRepository ProductPriceRepository
        {
            get { return _productPriceRepository ?? (_productPriceRepository = new ProductPriceRepository(_transaction)); }
        }
        public IPoDetailRepository PoDetailRepository
        {
            get { return _poDetailRepository ?? (_poDetailRepository = new PoDetailRepository(_transaction)); }
        }
        public IPoRepository PoRepository
        {
            get { return _poRepository ?? (_poRepository = new PoRepository(_transaction)); }
        }
        public IPermissionsRepository PermissionsRepository
        {
            get { return _permissionsRepository ?? (_permissionsRepository = new PermissionsRepository(_transaction)); }
        }
        public IBankCompanyBaseRepository BankCompanyBaseRepository
        {
            get { return _bankCompanyBaseRepository ?? (_bankCompanyBaseRepository = new BankCompanyBaseRepository(_transaction)); }
        }
        public IUserGroupRepository UserGroupRepository
        {
            get { return _userGroupRepository ?? (_userGroupRepository = new UserGroupRepository(_transaction)); }
        }
        public IBankBaseRepository BankBaseRepository
        {
            get { return _bankBaseRepository ?? (_bankBaseRepository = new BankBaseRepository(_transaction)); }
        }
        public IDeputyRepository DeputyRepository
        {
            get { return _deputyRepository ?? (_deputyRepository = new DeputyRepository(_transaction)); }
        }
        public IBrankBankBaseRepository BrankBankBaseRepository
        {

            get { return _brankBankBaseRepository ?? (_brankBankBaseRepository = new BrankBankBaseRepository(_transaction)); }
        }
        public IGroupSupplierRepository GroupSupplierRepository
        {
            get { return _iGroupSupplierRepository ?? (_iGroupSupplierRepository = new GroupSupplierRepository(_transaction)); }
        }
        public ICategoryRepository CategoryRepository
        {
            get { return _categoryRepository ?? (_categoryRepository = new CategoryRepository(_transaction)); }
        }
        public ISubSupplierRepository SubSupplierRepository
        {
            get { return _SubSupplierRepository ?? (_SubSupplierRepository = new SubSupplierRepository(_transaction)); }

        }
        public IClassProductRepository ClassProductRepository
        {
            get { return _classProductRepository ?? (_classProductRepository = new ClassProductRepository(_transaction)); }
        }
        public IProductRepository ProductRepository
        {
            get { return _productRepository ?? (_productRepository = new ProductRepository(_transaction)); }
        }
        public IClassSafetyRepository ClassSafetyRepository
        {
            get { return _classSafetyRepository ?? (_classSafetyRepository = new ClassSafetyRepository(_transaction)); }
        }
        public ICompanyRepository CompanyRepository
        {
            get { return _companyRepository1 ?? (_companyRepository1 = new CompanyRepository(_transaction)); }
        }
        public IStaffRepository StaffRepository
        {
            get { return _StaffRepository ?? (_StaffRepository = new StaffRepository(_transaction)); }
        }
        public ICurrencyUnitRepository CurrencyUnitRepository
        {
            get { return _currencyUnitRepository ?? (_currencyUnitRepository = new CurrencyUnitRepository(_transaction)); }
        }
        public IUsersRepository UsersRepository
        {
            get { return _usersRepository ?? (_usersRepository = new UsersRepository(_transaction)); }
        }
        public IDepartmentRepository DepartmentRepository
        {
            get { return _departmentRepository ?? (_departmentRepository = new DepartmentRepository(_transaction)); }
        }
        public IUserTypeRepository UserTypeRepository
        {
            get { return _userTypeRepository ?? (_userTypeRepository = new UserTypeRepository(_transaction)); }
        }
        public IQuotationRepository QuotationRepository
        {
            get { return _quotationRepository ?? (_quotationRepository = new QuotationRepository(_transaction)); }
        }
        public IGroupPartBaseRepository GroupPartBaseRepository
        {
            get { return _groupPartBaseRepository ?? (_groupPartBaseRepository = new GroupPartBaseRepository(_transaction)); }
        }
        public IQuotationDetailRepository QuotationDetailRepository
        {
            get
            {
                return _quotationDetailRepository ??
                       (_quotationDetailRepository = new QuotationDetailRepository(_transaction));
            }
        }
        public ISeriesRepository SeriesRepository
        {
            get { return _seriesRepository ?? (_seriesRepository = new SeriesRepository(_transaction)); }
        }
        public ILampTypeRepository LampTypeRepository
        {
            get { return _lampTypeRepository ?? (_lampTypeRepository = new LampTypeRepository(_transaction)); }
        }
        public IProductStandardRepository ProductStandardRepository
        {
            get { return _productStandardRepository ?? (_productStandardRepository = new ProductStandardRepository(_transaction)); }
        }
        public IMaterialRepository MaterialRepository
        {
            get { return _materialRepository ?? (_materialRepository = new MaterialRepository(_transaction)); }
        }
        public IPartBaseRepository PartBaseRepository
        {
            get { return _partBaseRepository ?? (_partBaseRepository = new PartBaseRepository(_transaction)); }
        }
        public ITypePartBaseRepository TypePartBaseRepository
        {
            get { return _typePartBaseRepository ?? (_typePartBaseRepository = new TypePartBaseRepository(_transaction)); }
        }
        public ISeriesPartBaseRepository SeriesPartBaseRepository
        {
            get { return _seriesPartBaseRepository ?? (_seriesPartBaseRepository = new SeriesPartBaseRepository(_transaction)); }
        }
        public ISourcingBaseRepository SourcingBaseRepository
        {
            get { return _sourcingBaseRepository ?? (_sourcingBaseRepository = new SourcingBaseRepository(_transaction)); }
        }
        public IStaffPositionRepository StaffPositionRepository
        {
            get
            {
                return _staffPositionReposity ?? (_staffPositionReposity = new StaffPostionRepository(_transaction));
            }
        }
        public IDebtRepository DebtRepository
        {
            get
            {
                return _debtRepository ?? (_debtRepository = new DebtRepository(_transaction));
            }
        }
        public INoteProjectDetailBaseRepository NoteProjectDetailBaseRepository
        {
            get { return _noteProjectDetailBaseRepository ?? (_noteProjectDetailBaseRepository = new NoteProjectDetailBaseRepository(_transaction)); }
        }
        public IIncomeExpenseRepository IncomeExpenseRepository
        {
            get { return _incomeExpenseRepository ?? (_incomeExpenseRepository = new IncomeExpenseRepository(_transaction)); }
        }
        public IProjectBaseRepository ProjectBaseRepository
        {
            get { return _projectBaseRepository ?? (_projectBaseRepository = new ProjectBaseRepository(_transaction)); }
        }

        public IRequestPaymentBaseRepository RequestPaymentBaseRepository
        {
            get { return _requestPaymentBaseRepository ?? (_requestPaymentBaseRepository = new RequestPaymentBaseRepository(_transaction)); }
        }

        public IPaymentMethodRepository PaymentMethodRepository
        {
            get { return _paymentMethodRepository ?? (_paymentMethodRepository = new PaymentMethodRepository(_transaction)); }
        }
        public IPaymentRepository PaymentRepository
        {
            get { return _paymentRepository ?? (_paymentRepository = new PaymentRepository(_transaction)); }
        }

        public ICompanyTypeRepository CompanyTypeRepository
        {
            get { return _companyTypeRepository ?? (_companyTypeRepository = new CompanyTypeRepository(_transaction)); }
        }
        public IObjectCoverRepository ObjectCoverRepositroy
        {
            get { return _objectCoverRepository ?? (_objectCoverRepository = new ObjectCoverRepositroy(_transaction)); }
        }
        public IRequestSentRepository RequestSentRepository
        {
            get { return _requestSentRepository ?? (_requestSentRepository = new RequestSentRepository(_transaction)); }
        }
        public IImportMaterialDetailRepository ImportMaterialDetailRepository
        {
            get { return _importMaterialDetailRepository ?? (_importMaterialDetailRepository = new ImportMaterialDetailRepository(_transaction)); }
        }
        public IImportMaterialRepository ImportMaterialRepository
        {
            get { return _importMaterialRepository ?? (_importMaterialRepository = new ImportMaterialRepository(_transaction)); }


        }

        public IStockRepository StockRepository { get; private set; }

        public ISuggestionRepository SuggestionRepository
        {
            get { return _suggestionRepository ?? (_suggestionRepository = new SuggestionRepository(_transaction)); }
        }

        public IStockMaterialRepository StockMaterialRepository
        {
            get { return _stockMaterialRepository ?? (_stockMaterialRepository = new StockMaterialRepository(_transaction)); }
        }

        public ILocationRepositor LocationRepository { get; private set; }

        public ILocationRepositor LocationRepositor
        {
            get { return ilocationRepositor ?? (ilocationRepositor = new LocationRepository(_transaction)); }
        }

       

        

    }
}
