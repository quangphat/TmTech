using System;

namespace TmTech_v1.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IStaffRepository StaffRepository { get; }
        IDeputyRepository DeputyRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IUsersRepository UsersRepository { get; }
        IUserTypeRepository UserTypeRepository { get; }
        IUserGroupRepository UserGroupRepository { get; }
        IPermissionsRepository PermissionsRepository { get; }
        IPoRepository PoRepository { get; }
        IPoDetailRepository PoDetailRepository { get; }
        IQuotationDetailRepository QuotationDetailRepository { get; }
        IQuotationRepository QuotationRepository { get; }
        IProductPriceRepository ProductPriceRepository { get; }
        IProductLineRepository ProductLineRepository { get; }
        ISeriesRepository SeriesRepository { get; }
        IProductStandardRepository ProductStandardRepository { get; }
        IClassProductRepository ClassProductRepository { get; }
        IClassSafetyRepository ClassSafetyRepository { get; }
        ILampTypeRepository LampTypeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        ISubSupplierRepository SubSupplierRepository { get; }
        IPlanningRepository PlanningRepository { get; }
        IPlanningDetailRepository PlanningDetailRepository { get; }
        IPartBaseRepository PartBaseRepository { get; }
        IGroupPartBaseRepository GroupPartBaseRepository { get; }
        ITypePartBaseRepository TypePartBaseRepository { get; }
        ISeriesPartBaseRepository SeriesPartBaseRepository { get; }
        ISourcingBaseRepository SourcingBaseRepository { get; }
        IBankCompanyBaseRepository BankCompanyBaseRepository { get; }
        IBankBaseRepository BankBaseRepository { get; }
        IBrankBankBaseRepository BrankBankBaseRepository { get; }
        IOriginRepository OriginRepository { get; }
        IUnitRepository UnitRepository { get; }
        IStaffPositionRepository StaffPositionRepository { get; }
        IGridViewRepository GridviewRepository { get; }
        IObjectCoverRepository ObjectCoverRepositroy { get; }
        ICurrencyUnitRepository CurrencyUnitRepository { get; }
        IDebtRepository DebtRepository { get; }
        INoteProjectDetailBaseRepository NoteProjectDetailBaseRepository { get; }
        IIncomeExpenseRepository IncomeExpenseRepository { get; }
        IDeliveryRepository DeliveryRepository { get; }
        IProjectBaseRepository ProjectBaseRepository { get; }
        IRequestPaymentBaseRepository RequestPaymentBaseRepository { get; }
        IPaymentMethodRepository PaymentMethodRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IApproveLogRepository ApproveLogRepository { get; }
        IDebtDetailRepository DebtDetailRepository { get; }
        ICompanyTypeRepository CompanyTypeRepository { get; }
        IProductPictureRepository ProductPictureRepository { get; }
        IRequestSentRepository RequestSentRepository { get; }
        IImportMaterialDetailRepository ImportMaterialDetailRepository { get; }
        IImportMaterialRepository ImportMaterialRepository { get; }
        IStockRepository StockRepository { get; }
        ISuggestionRepository SuggestionRepository { get; }
        IStockMaterialRepository StockMaterialRepository { get; }
        ILocationRepositor LocationRepository { get; }
        IProductTypeRepository ProductTypeRepository { get; }
        
        void Commit();

    }
}
