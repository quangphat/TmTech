using DapperExtensions.Mapper;
using System;
using System.Linq;
using System.Reflection;

namespace TmTech_v1.Model
{
    public class Material : CoreEntry
    {
        public string [] listColDesCription { get; set; }
        public Material()
        {
            listColDesCription = new string[] {
                "Tolerant","Leds","Lens"
                ,"Wirers"};
            Supplier = new Supplier();
        }
       
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public int SupplierId { get; set; }
        public double? Tolerant { get; set; }

        public string Photo { get; set; }
        public string PhotoPath
        {
            get
            {
                return Utility.PictureUtility.getImgLocation(Photo);
            }
            set
            {
                //string path = value;
                //Photo = Utility.PictureUtility.getFileName(path);
                Photo = value;
            }
        }
        public string Leds { get; set; }
        public string Lens { get; set; }
        public string Wirers { get; set; }
        public int Quality { get; set; }
        public string PartNumber { get; set; }
        public string Note { get; set; }
        public int InStock { get; set; }

        public Supplier Supplier { get; set; }
        public decimal Price { get; set; }
        public decimal _Price { get { return Price; } }
        public int MaterialQuantity { get; set; }
        public Guid ProductId { get; set; }
        public int TotalQuantity { get; set; }

        public int PlanningInstock
        {
            get
            {
                return (InStock - TotalQuantity);
            }
        }

        public string DepartmentCode { get; set; }
        public string StandardCode { get; set; }
        public int SeriesPartId { get; set; }
        public int TypePartId { get; set; }
        public int GroupPartId { get; set; }
        public int UnitId { get; set; }
        public string LoactionCode { get; set; }
        public string ProductTypeCode { get; set; }
        public GroupPart GropsupplierMaterial { get; set; }
        public TypePart TypePartMaterial { get; set; }
        public SeriesPart SeriesPartMaterial { get; set; }

        public string SeriesPartName
        {
            get
            {
                return SeriesPartMaterial != null ? SeriesPartMaterial.SeriesPartName : String.Empty ;
            }
        }

        public Unit UnitMaterial { get; set; }

        public string DescriptionDetail 
        {
            get
            {
                return listColDesCription != null ? ConvertToDescriptionImprove(this, listColDesCription,1) : String.Empty;
            }
        }

        public static string ConvertToDescriptionImprove<T>(T obj, string[] properties, int newline = 1) where T : class
        {
            string description = "";
            if (obj == null) return string.Empty;
            string value = "";
            PropertyInfo[] propInfos = obj.GetType().GetProperties();
            var listproperties = properties.ToList();
            if (propInfos != null)
            {
                foreach (PropertyInfo prop in propInfos)
                {
                    var lowerpropertie = prop.Name;
                    if (listproperties.Contains(lowerpropertie))
                    {
                        value = prop.GetValue(obj) != null ? prop.GetValue(obj).ToString() : "";
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            if (newline == 1)
                                description += prop.Name + ": " + value + "\n";
                            else
                                description += prop.Name + ": " + value + "\n\n";
                        }

                    }

                }
            }
            return description;
        }

    }
    public class MaterialMapper : ClassMapper<Model.Material>
    {
        public MaterialMapper()
        {
            Table("Material");
            Map(p => p.MaterialId).Key(KeyType.Identity);
            Map(p => p.Supplier).Ignore();
            Map(p => p.PhotoPath).Ignore();
            Map(p => p.MaterialQuantity).Ignore();
            Map(p => p.ProductId).Ignore();
            Map(p => p.TotalQuantity).Ignore();
            Map(p => p.PlanningInstock).Ignore();
            Map(p => p.GropsupplierMaterial).Ignore();
            Map(p => p.TypePartMaterial).Ignore();
            Map(p => p.SeriesPartMaterial).Ignore();
            Map(p => p.UnitMaterial).Ignore();
            Map(p => p._Price).Ignore();
            Map(p => p.SeriesPartName).Ignore();
            Map(p => p.listColDesCription).Ignore();
            Map(p => p.DescriptionDetail).Ignore();
            AutoMap();
        }
    }
}

