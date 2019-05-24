using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{

    public interface ISupplierRepository
    {
        void Add(Supplier entity);
        List<Supplier> All();
        int AddandGetSupplierID(Supplier entry);
        Supplier Find(int id);
        Supplier FindByGroupSupplierID(int id);
        void Remove(int id);
        void Remove(Supplier entity);
        void Update(Supplier entity);
        void EnableActive(int id);
        void DisableActive(int supplierId);
        List<Supplier> searchSupplier(string keySearch);
        int AddGroup(GroupSupplier groupsupplier);
        GroupSupplier FindGroupName(string groupname);
        Supplier Findsupplier(int id);
        int CheckExitSuplier(Supplier entity);
        void Updategroupsupplier(GroupSupplier groupsupplier);
        GroupSupplier FindGroupID(int groupname);
        void deletegroup(GroupSupplier m_groupsupplier);
        void DeleteGroupSupplier(int GroupID);
    }

}
