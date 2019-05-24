using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPermissionsRepository
    {
        void Add(Permissions entity);
        List<Permissions> All();
        Permissions Find(int id);
        void Remove(int id);
        void Remove(Permissions entity);
        void Update(Permissions entity);

        List<Permissions> GetPermission(int userGroupId);
    }

   


}
