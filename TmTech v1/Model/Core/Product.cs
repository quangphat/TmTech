using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class Product :CoreEntry
    {
        public Guid ProductId { get; set; }
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductLineId { get; set; }
        public int SeriesId { get; set; }
        public decimal Price { get; set; }
        public string DataSheet { get; set; }
        public string InstallGuide { get; set; }
        public string Dimension { get; set; }
        private string dimensionPath { get; set; }
        public string DimensionPath
        {
            get
            {
                return Utility.PictureUtility.getImgLocation(Dimension);
            }
            set
            {
                dimensionPath = value;
            }
        }
        public string Note { get; set; }
        public string Card3d { get; set; }
        public int UnitId { get; set; }
        public int? OriginId { get; set; }

        private string photoMeter;
        public string PhotoMeter
        {
            get
            {
                return Utility.PictureUtility.getImgLocation(photoMeter);
            }
            set
            {
                photoMeter = value;
            }
        }
        public string Photo { get; set; }
        private string photoPath;
        public string PhotoPath
        {
            get
            {
                return Utility.PictureUtility.getImgLocation(Photo);
            }
            set
            {
                photoPath = value;
            }
        }
        public virtual int Quantity { get; set; }
        public virtual SystemColor Color { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductLine Productline { get; set; }
        public virtual Series Series { get; set; }
        public virtual ProductStandard Standard { get; set; }
        public virtual ClassProduct ClassProduct { get; set; }
        public virtual ClassSafety ClassSafety { get; set; }
        private Unit unit;
        public Unit Unit
        {
            get
            {
                unit.UnitId = this.UnitId;
                return unit;
            }
            set
            {
                unit = value;
            }
        }
        public Product()
        {
            Quantity = 0;
            this.Price = 0;
            Color = new SystemColor();
            Category = new Category();
            Productline = new ProductLine();
            Series = new Series();
            Standard = new ProductStandard();
            ClassSafety = new ClassSafety();
            ClassProduct = new ClassProduct();
            Unit = new Unit();
        }
        public class ProductMapper:ClassMapper<Product>
        {
            public ProductMapper()
            {
                Table("Product");
                Map(p => p.Color).Ignore();
                Map(p => p.Quantity).Ignore();
                Map(p => p.Category).Ignore();
                Map(p => p.Productline).Ignore();
                Map(p => p.Series).Ignore();
                Map(p => p.Standard).Ignore();
                Map(p => p.ClassProduct).Ignore();
                Map(p => p.ClassSafety).Ignore();
                Map(p => p.PhotoPath).Ignore();
                Map(p => p.DimensionPath).Ignore();
                Map(p => p.Unit).Ignore();
                AutoMap();
            }
        }
    }
}