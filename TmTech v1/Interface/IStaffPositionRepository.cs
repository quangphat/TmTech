using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IStaffPositionRepository
    {
        void Add(StaffPosition entity);
        List<StaffPosition> All();
        StaffPosition Find(int id);
        void Remove(int id);
        void Remove(StaffPosition entity);
        void Update(StaffPosition entity);
    }
}
