
using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{

    public interface ICompanyBussiness
    {
        bool Delete(Company company);
        bool Delete(string companyId);
        CompanyReponse GetAll(CompanyRequest companyRequest = null);
        int Insert(Company company);
        int Update(Company company);
        Company GetById(int companyId);
        void EnableActive(int companyId);
        void InActive(int companyId);
    }
    public interface IUserBussiness
    {
        Users GetByName(string userName);

    }

    public interface IRequestPaymentBussiness
    {
        bool Delete(PaymentRequest company);
        bool Delete(string companyId);
        RequestPaymentReponse GetAll(RequestPaymentRequest companyRequest = null);
        int Insert(PaymentRequest company);
        void Update(PaymentRequest company);
        PaymentRequest GetById(int companyId);
        string GetRequestPaymentCode(int companyId, DateTime dtmDateMake);
    }
    public interface IStaffBussiness
    {
        Staff GetByName(string userName);
        Staff GetById(int staffId);
    }

    public interface ISupplierBussiness
    {
        List<Supplier> All();
        int AddandGetSupplierID(Supplier entry);
        Supplier Find(int id);
        Supplier FindByGroupSupplierID(int id);
        void Remove(int id);
        void Remove(Supplier entity);
        int Update(Supplier entity);
        void EnableActive(int id);
        List<Supplier> SearchSupplier(string keySearch);
        int AddgetID(GroupSupplier groupsupplier);
        GroupSupplier AddandGetSupplierID(Supplier entry, string parrentgroup);

    }
}
