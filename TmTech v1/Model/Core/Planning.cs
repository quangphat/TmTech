using DapperExtensions.Mapper;
using System;
using TmTech_v1.Utility;

namespace TmTech_v1.Model
{
    public class Planning :CoreEntry
    {
        public Guid PlanningId { get; set; }
        public string PlanningCode { get; set; }
        public string PlanningName { get; set; }
        public string PoCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int StatusId { get; set; }
        public bool LoadPo { get; set; }
        //private int dayLeft;
        //state field on planning file.
        public string Dayleft
        {
            get
            {
                int temp = (DeliveryDate-DateTime.Today).Days;
                if (StatusId == (int)ProgressStatus.Finish)
                    return "Finish";
                return temp.ToString();
            }
        }
        public int DayMake
        {
            get
            {
                return DateTime.Compare(DeliveryDate, Po.ApproveDate.Value);
            }
        }
        public Po Po { get; set; }
        public Staff Staff { get; set; }
    }
    public class PlanningMapper:ClassMapper<Planning>
    {
        public PlanningMapper()
        {
            Table("Planning");
            Map(p => p.Po).Ignore();
            Map(p => p.Staff).Ignore();
            AutoMap();
        }
    }
}
