using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ICompanyRepository
    {
        void Add(Company entity);
        List<Company> All();
        void InActive(int id);
        void InActive(Company entity);
        Company Find(int id);
        List<Company> SearchCompany(string keysearch);
        void Update(Company entity);
        int AddandGetCompanyId(Company entity);
        void EnableActive(int comPanyId);
        List<CompanyClass> AllClass();
        int CheckExitCompany(Company entity);

    }


}
