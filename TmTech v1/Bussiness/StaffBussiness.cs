using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{
    public class StaffBussiness : IStaffBussiness
    {
        public Staff GetByName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                return null;
            Staff users;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                var usserId = uow.UsersRepository.Find(userName);
                users = uow.StaffRepository.Find(usserId);
            }
            return users;
        }

        public Staff GetById(int staffId)
        {
            if (staffId <1)return null;
            Staff users;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                users = uow.StaffRepository.Find(staffId);
            }
            return users;
        }
    }
}
