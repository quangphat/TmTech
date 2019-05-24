using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProjectBaseRepository:IBaseRepository<Project>
    {
        List<Project> Find(DateTime begin, DateTime end);
        string GetProjectCode(int companyId, DateTime createDate);
        List<Status> GetAllStatus();
    }
}
