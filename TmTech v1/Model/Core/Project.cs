using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Project:CoreEntry
    {
        public Project()
        {
            Staff = new Staff();
            Company = new Company();
            Status = new Status();
        }
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string DrawingName { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? Sale { get; set; }
        public int? CompanyId { get; set; }
        public int? StatusId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Company Company { get; set; }
        public virtual Status Status { get; set; }
    }

    public class ProjectMapper:ClassMapper<Project>
    {
        public ProjectMapper()
        {
            Table("Project");
            Map(p => p.Staff).Ignore();
            Map(p => p.Company).Ignore();
            Map(p => p.Status).Ignore();
            AutoMap();
        }
    }
}
