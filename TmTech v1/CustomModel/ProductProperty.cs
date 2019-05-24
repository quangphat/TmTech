using System;
namespace TmTech_v1.CustomModel
{
    public class ProductProperty
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public Guid ProductId { get; set; }
        public string TableName { get; set; }
    }
}
