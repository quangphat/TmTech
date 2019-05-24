using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{
    public class UserBussiness : IUserBussiness
    {

        public Users GetByName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                return null;
            Users users;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var usserId = uow.UsersRepository.Find(userName);
                users = uow.UsersRepository.Find(usserId);
            }
            return users;
        }
    }


    
}
 