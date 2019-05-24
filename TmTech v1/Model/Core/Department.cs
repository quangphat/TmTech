using DapperExtensions.Mapper;
namespace TmTech_v1.Model
{
    public class Department :CoreEntry
    {
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public int? HeaderId { get; set; }
        public string Note { get; set; }
        public int Quantity { get; set; }
        public Staff Staff { get; set; }
    }
    public class DepartmentMapper: ClassMapper<Department>
    {
        public DepartmentMapper()
        {
            Table("Department");
            Map(p => p.Staff).Ignore();
            Map(p => p.Quantity).Ignore();
            AutoMap();
        }
    }
}