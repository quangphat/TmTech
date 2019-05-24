using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ICompanyTypeRepository
    {
        void Add(CompanyType entity);
        List<CompanyType> All();
        CompanyType Find(int id);
        void Remove(int id);
        void Remove(CompanyType entity);
        void Update(CompanyType entity);
    }
}
