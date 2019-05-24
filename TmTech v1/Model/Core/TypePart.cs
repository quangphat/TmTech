namespace TmTech_v1.Model
{
    public class TypePart : CoreEntry
    {
        public TypePart  () 
        {
        }
        public int TypePartID { get; set; }
        public string TypePartCode { get; set; }
        public string TypePartName { get; set; }
        public int? GroupPartId { get; set; }
        public string Note { get; set; }
        
    }

}
