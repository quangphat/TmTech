using System.Collections.Generic;

namespace TmTech_v1.Interface
{
    public interface IQuotationDetailRepository
    {
        void Add(Model.QuotationDetail entity);
        List<Model.QuotationDetail> All();
        List<Model.QuotationDetail> AllList(int SQuoation); 
        Model.QuotationDetail Find(int id);
        Model.QuotationDetail Find(Model.Quotation quotation, Model.Product product);
        List<Model.QuotationDetail> Find(Model.Quotation quotation);
        void Remove(int id);
        void Remove(Model.QuotationDetail entity);
        void Update(Model.QuotationDetail entity);
        void CopyQuotation(Model.Quotation fromquotation, Model.Quotation toQuotation);
    }
}
