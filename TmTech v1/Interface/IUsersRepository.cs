using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IUsersRepository
    {
        void  Add(Users entity);
        List<Users> All();
        List<Users> FindByGroup(int userTypeId);
        Users Find(int id);
        Users FindUserName(string userName);
        Users IsExist(string  userName);
        void Remove(int id);
        void Remove(Users entity);
        void Update(Users entity);
        Users Login(string username, string password);
        int Find(string username);
        int AddAndGetID(Model.Users entity);
    }
}
