using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class PlanningDetail :CoreEntry
    {
        public Guid PlanningDetailId { get; set; }
        public string PlanningCode { get; set; }
        public Guid QuotationDetailId { get; set; }
    }
    public class PlanningDetailMapper : ClassMapper<PlanningDetail>
    {
        public PlanningDetailMapper()
        {
            Table("PlanningDetail");
            AutoMap();
        }
    }
}
