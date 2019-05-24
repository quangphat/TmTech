namespace TmTech_v1.Model
{
    public class BrankBank : CoreEntry
    {
        public BrankBank()
        {
            Bank = new Bank();
        }

        public virtual Bank Bank { get; set; }
        public int BankId { get; set; }
        public string BrankAddress { get; set; }
        public int BrankBankID { get; set; }
        public string BrankName { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
    }
}
