using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
namespace TmTech_v1.Repository
{
    public class DepartmentRepository : RepositoryBase<Model.Department>, IDepartmentRepository
    {
        public DepartmentRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Department entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Department(DepartmentCode,DepartmentName,Quantity,HeaderId,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@DepartmentCode,@DepartmentName,@Quantity,@HeaderId,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Department> All()
        {
            return Connection.Query<Model.Department, Model.Staff, Model.Department>("select d.*,[dbo].CountQuantityStaff(d.DepartmentId) as Quantity,s.StaffName from Department d left join Staff s on d.HeaderId = s.StaffId", (d, s) => { d.Staff = s; return d; }, splitOn: "StaffName", transaction: Transaction).ToList();
            //return base.GetAll();
        }

        public Model.Department Find(int id)
        {
            //return Connection.Query<Model.Department>("select * from Department where DepartmentId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            return base.Get(p => p.DepartmentId,id);
        }

        public void Remove(int id)
        {
            //Connection.Execute("delete from Department where DepartmentId = @Id", param: new { Id = id }, transaction: Transaction);
            base.Delete(p => p.DepartmentId , id);
        }

        public void Remove(Model.Department entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }

        public void Update(Model.Department entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }


    }

}
