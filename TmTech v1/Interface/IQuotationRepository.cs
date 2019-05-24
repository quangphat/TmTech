using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IQuotationRepository
    {
        void Add(Model.Quotation entity);
        List<Model.Quotation> All();
        Model.Quotation Find(int id);
        Model.Quotation Find(string code);
        void Remove(int id);
        void Remove(Model.Quotation entity);
        void Update(Model.Quotation entity);
        List<Quotation> Search(string searchStr);
        string GetQuotationCode(int companyId, DateTime dtmDateMake);
        List<Model.Quotation> LookByDate(DateTime fromDate, DateTime toDate);
        List<Model.Quotation> LookByCompany(Model.Company company);
        void DeleteNullQuotation(Model.Quotation quotation);
        bool CodeExists(Model.Quotation quotation);
        void Lock(Quotation quotation);
    }
}
