using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class Bank : CoreEntry
    {
        public string Address { get; set; }
        public string BankCode { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
        public string Phone { get; set; }
    }

   
    public class BrankBankMapper : ClassMapper<BrankBank>
    {
        public BrankBankMapper()
        {
            Table("BrankBank");
            Map(p => p.Bank).Ignore();
            Map(p => p.BrankBankID).Ignore();
            AutoMap();
        }
    }

    
}

