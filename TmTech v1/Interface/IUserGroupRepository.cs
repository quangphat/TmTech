using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IUserGroupRepository
    {
        void Add(UserGroup entity);
        List<UserGroup> All(); 
        UserGroup Find(int id);
        void Remove(int id);
        void Remove(UserGroup entity);
        void Update(UserGroup entity);
    }
}
