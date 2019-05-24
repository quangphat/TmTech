namespace TmTech_v1.Model
{
    public class RequestParamaterEditTypeForm
    {
       public  SeriesPart seriesPart { get; set; }
       public GroupPart groupPart { get; set; }
        public TypePart typePart { get; set; }
     public  EditTypeRequest  editTypeRequestFrm { get; set; }
     
    }
    public enum EditTypeRequest
    {
        SeriesPart,
        GroupPart,
        TypePart
    }
}
