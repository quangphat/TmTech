namespace TmTech_v1.Model
{
    public class RequestSent:CoreEntry
    {
        public int RequestSentId { get; set; }
        public string TableName { get; set; }
        public string RequestBy { get; set; }
        public string RequestTo { get; set; }
        public string Detail { get; set; }
        public int? IdValue { get; set; }

    }

}
