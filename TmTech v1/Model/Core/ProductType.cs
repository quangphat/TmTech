using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class ProductType : CoreEntry
    {
        public Guid ProductTyeID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

    }

    public class ProductTypeMapper:ClassMapper<ProductType>
    {
        public ProductTypeMapper()
        {
            Table("ProductType");

			AutoMap();
        }
    }
}

