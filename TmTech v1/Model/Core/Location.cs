using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Location : CoreEntry
    {
        public Guid LocationID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

    }

    public class LocationMapper:ClassMapper<Location>
    {
        public LocationMapper()
        {
            Table("Location");

			AutoMap();
        }
    }
}

