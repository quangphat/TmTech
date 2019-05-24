using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IApproveLogRepository
    {
        void Add(ApproveLog entity);
        List<ApproveLog> All();
        ApproveLog Find(int id);
    }
}
