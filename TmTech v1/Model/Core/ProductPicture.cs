using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class ProductPicture:CoreEntry
    {
        public int ProductPictureId { get; set; }
        public Guid ProductId { get; set; }
        public string Picture { get; set; }
    }
    public class ProductPictureMapper : ClassMapper<ProductPicture>
    {
        public ProductPictureMapper()
        {
            Table("ProductPicture");
            Map(p => p.CreateBy).Ignore();
            Map(p => p.CreateDate).Ignore();
            Map(p => p.ModifyBy).Ignore();
            Map(p => p.ModifyDate).Ignore();
            AutoMap();
        }
    }

}
