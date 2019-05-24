using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    class DebtRepository : RepositoryBase<Model.Debt>, IDebtRepository
    {
        public DebtRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(Debt entity)
        {
            if(entity==null)
                throw new ArgumentNullException("entity");
            base.Insert(entity);
        }

        public List<Debt> All()
        {
            throw new NotImplementedException();
        }

        public Debt Find(int id)
        {
            throw new NotImplementedException();
        }


        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Debt entry)
        {
            throw new NotImplementedException();
        }

        public List<Debt> Search(string searchStr = "")
        {
            return Connection.Query<Debt, Model.Company, Model.Po, Model.Debt>("LookForDebtbyName", (d, c, p) => { d.Company = c; d.Po = p; ;return d; }, new { @searchStr = searchStr }
            ,splitOn:"CompanyId,WarrantyPercent", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public void Update(Debt entry)
        {
            base.Edit(entry);
        }


        public List<DebtDetail> Find(Debt debt)
        {
            return Connection.Query<DebtDetail>("select * from DebtDetail where DebtId = @DeptId", new { DeptId = debt.DebtId }, transaction: Transaction).ToList();
        }
    }
}
