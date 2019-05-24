using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Delivery:CoreEntry
    {
        public Guid DeliveryId { get; set; }
        public string DeliveryCode { get; set; }
        public string POCode { get; set; }
        public int CompanyId { get; set; }
        public DateTime? DeliveryDate { get; set; }

    }
    public class DeliveryMapper:ClassMapper<Delivery>
    {
        public DeliveryMapper()
        {
            Table("Delivery");
            AutoMap();
        }
    }
}
