namespace TmTech_v1.Model
{
    public  class ViewSupplierSourcing:CoreEntry
    {

        public string SupplierName { get; set; }
        public string SupplierId { get; set; }
        public string SubSupplierName { get; set; }
        public string AddressSupplier { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string GroupPartName { get; set; }
        public string GroupPartID { get; set; }
        public string TypePartName { get; set; }
        public string TypePartID { get; set; }
        public string SeriesPartName { get; set; }
        public string SeriesPartId { get; set; }
        public string partName { get; set; }
        public string PartID { get; set; }
        public string PartNumber { get; set; }
        public string Email { get; set; }
        public bool StatusSupplier { get; set; }
        public string NOte { get; set; }
        public decimal? Pricespart { get; set; }
    }

    public class InformationSearch
    {
        public int SupplierID { get; set; }
        public int GroupPartID { get; set; }
        public int TypePartID { get; set; }
        public int SeriesPartID { get; set; }
        public int PartID { get; set; }
        public InformationSearch()
        {
            SupplierID = 100;
            GroupPartID = TypePartID = SeriesPartID = PartID = 0;
        }



    }
}
