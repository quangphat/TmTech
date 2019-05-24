using DapperExtensions.Mapper;
using System;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.Model
{
    public class Debt : CoreEntry
    {
        public Debt()
        {
            Company = new Company();
            Po = new Po();
        }
        public int DebtId { get; set; }
        public string DeliveryCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string POCode { get; set; }
        public string Bill { get; set; }

        public decimal TotalValue { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal TotalDebt { get; set; }
        public decimal TotalPaymentPerCompany { get; set; }
        private decimal restValuePerCompany;
        public decimal RestValuePerCompany
        {
            get
            {
                return TotalDebt - TotalPaymentPerCompany;
            }
        }
        private decimal restValue;
        public decimal RestValue
        {
            get
            {
                return (TotalValue - TotalPayment);
            }
            set
            {
                restValue = value;
            }
        }
        //private string ask;
        public string Ask
        {
            get
            {
                if (DeliveryDate == null)
                    return "Finish";
                int days = (DeliveryDate - DateTime.Today).Days;
                if (days <= 0)
                    return "Finish";
                return days.ToString();
            }
        }
        public virtual Company Company { get; set; }
        public virtual Po Po { get; set; }
        public static void CreateDebt(Po po, IUnitOfWork uow)
        {
            //create delivery.
            Delivery delivery = new Delivery();
            delivery.SetCreate();
            delivery.POCode = po.PoCode;
            delivery.CompanyId = po.CompanyId;
            //create debt
            Debt debt = new Debt();
            debt.POCode = po.PoCode;
            debt.SetCreate();
            delivery.DeliveryCode = uow.DeliveryRepository.CreateCode(po.Company, DateTime.Today);
            uow.DeliveryRepository.Add(delivery);
            if (po.CreateDebt == true)
            {
                debt.DeliveryCode = delivery.DeliveryCode;
                uow.DebtRepository.Add(debt);
            }
            Quotation quotation = new Quotation();
            quotation.ApproveStatusId = (int)ApproveStatus.Approved;
            quotation.QuotationCode = po.QuotationCode;
            uow.QuotationRepository.Lock(quotation);
            uow.PlanningRepository.CreateFromPO(po);

        }
    }

    public class DebtMapper:ClassMapper<Debt>
    {
        public DebtMapper()
        {
            Table("Debt");
            Map(p => p.Company).Ignore();
            Map(p => p.Po).Ignore();
            Map(p => p.TotalValue).Ignore();
            Map(p => p.TotalPayment).Ignore();
            Map(p => p.RestValue).Ignore();
            Map(p => p.DeliveryDate).Ignore();
            Map(p => p.Ask).Ignore();
            Map(p => p.TotalDebt).Ignore();
            Map(p => p.RestValuePerCompany).Ignore();
            Map(p => p.TotalPaymentPerCompany).Ignore();
            AutoMap();
        }
    }
}
