using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IUserTypeRepository
    {
        void Add(UserType entity);
        List<UserType> All(); 
        UserType Find(int id);
        void Remove(int id);
        void Remove(UserType entity);
        void Update(UserType entity);

    }
}
