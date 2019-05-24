namespace TmTech_v1.Model
{
    public class ImportInventory :CoreEntry
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? InventoryId { get; set; }
        public int? Quantity { get; set; }
        public string Note { get; set; }
    }
}
