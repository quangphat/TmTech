namespace TmTech_v1.Model
{
    public class Suggestion:CoreEntry
    {
        public int SuggestionId { get; set; }
        public string MyName { get; set; }
        public int? DepartmentId { get; set; }
        public int? PurposeSuggestionId { get; set; }
        public string Content { get; set; }
        public decimal? MoneyNum { get; set; }
        public string MoneyNumWrite { get; set; }
        public decimal? ReturnMoneyNum { get; set; }
        public string ReturnMoneyNumWrite { get; set; }
    }

}
