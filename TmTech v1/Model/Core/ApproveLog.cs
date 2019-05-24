using DapperExtensions.Mapper;
using System;
namespace TmTech_v1.Model
{
    public class ApproveLog:CoreEntry
    {
        public int ApproveId { get; set; }
        public string ApproveCode { get; set; }
        public int ApproveStatusId { get; set; }
        public string ApproveBy { get; set; }
        public DateTime ApproveDate { get; set; }
    }
    public class ApproveLogMapper : ClassMapper<ApproveLog>
    {
        public ApproveLogMapper()
        {
            Table("ApproveLog");
            Map(p => p.CreateBy).Ignore();
            Map(p => p.CreateDate).Ignore();
            Map(p => p.ModifyBy).Ignore();
            Map(p => p.ModifyDate).Ignore();
            AutoMap();
        }
    }
}