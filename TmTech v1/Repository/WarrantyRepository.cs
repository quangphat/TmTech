using TmTech_v1.Model;
using TmTech_v1.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace TmTech_v1.Repository
{
    public class WarrantyRepository : RepositoryBase<Warranty>, IWarranty
    {
        public WarrantyRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(Warranty entry)
        {
            throw new NotImplementedException();
        }

        public int AddandGetRequestPaymentId(Warranty entry)
        {
            throw new NotImplementedException();
        }

        public List<Warranty> All()
        {
            throw new NotImplementedException();
        }

        public Warranty Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Warranty entry)
        {
            throw new NotImplementedException();
        }

        public void Update(Warranty entry)
        {
            throw new NotImplementedException();
        }
    }
}
