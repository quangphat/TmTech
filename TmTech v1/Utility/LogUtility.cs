using System;
using TmTech_v1.Model;
using TmTech_v1.Interface;

namespace TmTech_v1.Utility
{
    public static class LogUtility
    {
        public static void WriteLog(string Code, int ApproveStatus,IUnitOfWork uow)
        {
            ApproveLog log = new ApproveLog();
            log.ApproveCode = Code;
            log.ApproveStatusId = ApproveStatus;
            log.ApproveDate = DateTime.Now;
            log.ApproveBy = UserManagement.UserSession.UserName;
            log.SetCreate();
            uow.ApproveLogRepository.Add(log);
        }
        public static void WriteLog(ApproveLog log, IUnitOfWork uow)
        {
            if (uow == null)
                uow = new UnitOfWork();
            log.SetCreate();
            log.ApproveDate = DateTime.Now;
            log.ApproveBy = UserManagement.UserSession.UserName;
            uow.ApproveLogRepository.Add(log);
        }
    }
}
