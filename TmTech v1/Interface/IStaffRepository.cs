using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IStaffRepository
    {
        void Add(Staff entity);
        List<Staff> All();
        Staff Find(int id);
        void Remove(int id);
        void Remove(Staff entity);
        void Update(Staff entity);
        List<Model.Staff> FindByDepartment(int departmentId);
        Model.Staff SearchStaff(string keysearch);
    }
}
