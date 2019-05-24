using System;
using System.Collections.Generic;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Bussiness
{

    public class RequestPaymentRequest
    {
        public string Token;
    }
    public class RequestPaymentReponse
    {
        public List<PaymentRequest> List { get; set; }
    }
    public class RequestPaymentBussiness : IRequestPaymentBussiness
    {
        public bool Delete(PaymentRequest requestPayment)
        {
            if (requestPayment == null)
                return false;
            bool resulf;
            using (var uow = new UnitOfWork())
            {
                try
                {
                    uow.RequestPaymentBaseRepository.Remove(requestPayment);
                    uow.Commit();
                    resulf = true;
                }
                catch (Exception)
                {

                    resulf = false;
                }
            }
            return resulf;
        }

        public bool Delete(string requestPaymentId)
        {
            if (string.IsNullOrEmpty(requestPaymentId))
            {
                return false;
            }
            bool resulf;
            using (var uow = new UnitOfWork())
            {
                try
                {
                    uow.RequestPaymentBaseRepository.Remove(int.Parse(requestPaymentId));
                    uow.Commit();
                    resulf = true;
                }
                catch (Exception)
                {

                    resulf = false;
                }
            }
            return resulf;
        }

        public RequestPaymentReponse GetAll(RequestPaymentRequest requestPaymentRequest = null)
        {
            List<PaymentRequest> list;

            using (IUnitOfWork uow = new UnitOfWork())
            {
                list = uow.RequestPaymentBaseRepository.All();
            }
            return new RequestPaymentReponse()
            {
                List = list

            };
        }

        public int Insert(PaymentRequest requestPayment)
        {
            if (requestPayment == null)
                return 0;
            int requestPaymentId;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                requestPaymentId = uow.RequestPaymentBaseRepository.AddandGetRequestPaymentId(requestPayment);
                uow.Commit();
            }
            return requestPaymentId;
        }

        
        public void Update(PaymentRequest requestPayment )
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                uow.RequestPaymentBaseRepository.Update(requestPayment);
                uow.Commit();
            }
        }

        public PaymentRequest GetById(int requestPaymentId)
        {
            if (requestPaymentId < 1)
                return null;
            PaymentRequest requestPayment;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                requestPayment = uow.RequestPaymentBaseRepository.Find(requestPaymentId);

            }
            return requestPayment;
        }

        public  string GetRequestPaymentCode(int companyId, DateTime dtmDateMake)
        {
            if (companyId < 1)
                return string.Empty;
            string requestCode;
            using (IUnitOfWork uow = new UnitOfWork())
            {
                requestCode = uow.RequestPaymentBaseRepository.GetRequestPaymentCode(companyId, dtmDateMake);

            }
            return requestCode;

        }
        
    }
}
