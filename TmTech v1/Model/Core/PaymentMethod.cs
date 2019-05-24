namespace TmTech_v1.Model
{
    public class PaymentMethod:CoreEntry
    {
        public int PaymentMethodId { get; set; }
        public string MethodCode { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }

}
