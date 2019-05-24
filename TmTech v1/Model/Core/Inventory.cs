namespace TmTech_v1.Model
{
    public class Inventory :CoreEntry
    { 
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public string Address { get; set; }
        public double? Width { get; set; }
        public double? Long { get; set; }
        public int? StaffId { get; set; }
        public string Note { get; set; }
  
    }
}
