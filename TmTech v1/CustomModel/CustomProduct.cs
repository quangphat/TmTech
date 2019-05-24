using System;
using TmTech_v1.Model;
namespace TmTech_v1.CustomModel
{
    public class CustomProduct : Model.Product
    {
        public int QuotationId { get; set; }
        public string QuotationCode { get; set; }
        public string ProductUnit { get; set; }
        public int QuotationDetailId { get; set; }
        public int CompanyId { get; set; }
        public DateTime? QuoCreateDate { get; set; }
        public DateTime? QuoModifyDate { get; set; }
        public string UnitName { get; set; }
        public string QuoCreateBy { get; set; }
        public string QuoModifyBy { get; set; }
        public decimal BasePrice { get; set; }
        private decimal quotationPrice;
        public decimal QuotationPrice
        {
            get
            {
                return quotationPrice;
            }
            set
            {
                quotationPrice = value;
            }
        }
        public Guid POId { get; set; }
        public string PoCode { get; set; }
        public Guid PODetailId { get; set; }
        private decimal poPrice;
        public decimal POPrice
        {
            get
            {
                return poPrice;
            }
            set
            {
                poPrice = value;
            }
        }
        private decimal totalMoney;
        public decimal TotalMoney
        {
            get
            {
                if(quotationPrice!=0 && poPrice==0)
                     return Quantity * quotationPrice;
                else
                    return Quantity * poPrice;
            }
            set
            {
                totalMoney = value;
            }

        }
        public string totalDescription;
        public string TotalDescription
        {
            get
            {
                //totalDescription = "Watt :" + Watt + "\n" + "InputVoltage: " + InputVoltage + "\n " + "Watt :" + Watt + "\n " + "Pixel: " + Pixel + "\n" +
                //                   "Angle: " + Angle + "\n Housing: " + Housing + "\n Profile housing :" + Profilehousing + "\n" +
                //                   "Temperature :" + Temperature + "\n IKRate: " + IKRate+ "\n IPRate: " + IPRate + "\n Head: " + Head + "\n Cri: " + (CRI==null?"":CRI.ToString()) + "\n";             
                return totalDescription = string.Empty;
            }
            set
            {
                totalDescription = value;
            }
        }
        public static void ConvertToProduct(CustomProduct cusProduct, Product product)
        {
            product.Barcode = cusProduct.Barcode;
            product.ProductCode = cusProduct.ProductCode;
            product.ProductName = cusProduct.ProductName;
            product.SeriesId = cusProduct.SeriesId;
            product.DataSheet = cusProduct.DataSheet;
            product.InstallGuide = cusProduct.InstallGuide;
            product.PhotoMeter = cusProduct.PhotoMeter;
            product.PhotoPath = cusProduct.PhotoPath;
            product.Note = cusProduct.Note;
            product.Card3d = cusProduct.Card3d;
            product.CreateDate = cusProduct.CreateDate;
            product.CreateBy = cusProduct.CreateBy;
            product.ModifyDate = cusProduct.ModifyDate;
            product.ModifyBy = cusProduct.ModifyBy;
            product.Price = cusProduct.Price;
            product.Quantity = cusProduct.Quantity;
            product.Color = cusProduct.Color;
            product.Category = cusProduct.Category;
            product.Productline = cusProduct.Productline;
            product.Series = cusProduct.Series;
            product.Standard = cusProduct.Standard;
            product.ClassProduct = cusProduct.ClassProduct;
            product.ClassSafety = cusProduct.ClassSafety;
        }
        public static void ConvertToCustom(Product product, CustomProduct custom)
        {
            custom.Barcode = product.Barcode;
            custom.ProductCode = product.ProductCode;
            custom.ProductName = product.ProductName;
            custom.SeriesId = product.SeriesId;
            custom.DataSheet = product.DataSheet;
            custom.InstallGuide = product.InstallGuide;
            custom.PhotoMeter = product.PhotoMeter;
            custom.PhotoPath = product.PhotoPath;
            custom.Note = product.Note;
            custom.Card3d = product.Card3d;
            custom.CreateDate = product.CreateDate;
            custom.CreateBy = product.CreateBy;
            custom.ModifyDate = product.ModifyDate;
            custom.ModifyBy = product.ModifyBy;
            custom.Price = product.Price;
            custom.Quantity = product.Quantity;
            custom.Color = product.Color;
            custom.Category = product.Category;
            custom.Productline = product.Productline;
            custom.Series = product.Series;
            custom.Standard = product.Standard;
            custom.ClassProduct = product.ClassProduct;
            custom.ClassSafety = product.ClassSafety;
        }
    }
}
