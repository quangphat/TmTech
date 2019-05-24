using DapperExtensions.Mapper;
using System;

namespace TmTech_v1.Model
{
    public class QuotationDetail : CoreEntry
    {
        public QuotationDetail()
        {
            product = new Product();
        }
        public Guid QuotationDetailId { get; set; }
        public string QuotationDetailCode { get; set; }
        public string QuotationCode { get; set; }
        public Guid ProductId { get; set; }
        public int? SupplierId { get; set; }
        public int Quantity { get; set; }
        public string Standard { get; set; }
        public string CustomerProductCode { get; set; }
        private double vat;
        public double VAT
        {
            get
            {
                return vat * 100;
            }
            set
            {
                vat = value / 100;
            }
        }
        public string WarrantyTime { get; set; }
        public DateTime DeliveryTime {get;set;}
        public decimal? BasePrice { get; set; }
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
        public string LampType { get; set; }
        public string ClassSafety { get; set; }
        public string Angle { get; set; }
        public string ClassProduct { get; set; }
        public string Temperature { get; set; }
        public string IPRate { get; set; }
        public string IKRate { get; set; }
        public string Control { get; set; }
        public string ProfileHousing { get; set; }
        public string Housing { get; set; }
        public string Head { get; set; }
        public string Watt { get; set; }
        public string Cri { get; set; }
        public string InputVoltage { get; set; }
        public string BranchOfLed { get; set; }
        public string ColorHousing { get; set; }
        public string Color { get; set; }
        public string Enec { get; set; }
        public string Pixel { get; set; }
        public double? Discount { get; set; }
        public string Note { get; set; }
        public virtual Quotation Quotation { get; set; }
        private Product product;
        public Product Product
        {
            get
            {
              
                product.ProductId = this.ProductId;
                return product;
            }
            set
            {
                product = value;
            }
        }
        private string totalDescription;
        public string TotalDescription
        {
            get
            {
                //totalDescription = "Input Voltage :" + InputVoltage + "\n" + "Dimension: " + Dimension + "\n " + "Branch of Led :" + BranchOfLed + "\n " + "Power consumption: " + Watt + "\n" +
                //                   "Finishing (Color housing): " + ColorHousing + "\n Color: " + Color + "\n Beam Angle :" + Angle + "\n" +
                //                   "IP rate :" + IPRate + "\n Class: " + ClassProduct;   
                //totalDescription = "";
                return totalDescription;
            }
            set
            {
                totalDescription = value;
            }
        }
        private decimal totalMoney;
        public decimal TotalMoney
        {
            get
            {
                    return Quantity * quotationPrice;
            }
            set
            {
                totalMoney = value;
            }

        }
    }
    public class QuotationDetailMapper : ClassMapper<QuotationDetail>
    {
        public QuotationDetailMapper()
        {
            Table("QuotationDetail");
            Map(p => p.Quotation).Ignore();
            Map(p => p.TotalMoney).Ignore();
            Map(p => p.Product).Ignore();
            Map(p => p.TotalDescription).Ignore();
            AutoMap();
        }
    }
}
