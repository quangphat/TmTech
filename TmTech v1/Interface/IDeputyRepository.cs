using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IDeputyRepository
    {
        void Add(Deputy entity);
        List<Deputy> All();
        List<Deputy> GetByCompany(Company company);
        Deputy Find(int id);
        Deputy Find(string Account);
        Deputy FindMainDeputy(int id);
        void Remove(int id);
        void Remove(Deputy entity);
        void Update(Deputy entity);
        bool CheckIsMain(int companyId);
    }

    public interface ISubSupplierRepository
    {
        void Add(SubSupplier entity);
        List<SubSupplier> All();
        List<SubSupplier> GetBySupplierID(int companyId);
        SubSupplier Find(int id);
        SubSupplier Find(string Account);
        SubSupplier FindMainSubsupplier(int id);
        void Remove(int id);
        void Remove(SubSupplier entity);
        void Update(SubSupplier entity);
        void UnckeckMain(int supplierId, int numbertrue);
        bool AllowUpdateIsmain(int supplierId);
         List<SubSupplier> GetbySupplier(Supplier company);

    }
}
