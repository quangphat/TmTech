using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.Repository
{
    public class PlanningRepository : RepositoryBase<Model.Planning>, IPlanningRepository
    {
        public PlanningRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Planning entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Planning(PlanningId,PlanningCode,PlanningName,StatusId,PoCode,LoadPo,CreateDate,CreateBy,ModifyDate,ModifyBy) 
            //        values (NEWID(),@PlanningCode,@PlanningName,@StatusId,@PoCode,@LoadPo,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.Planning> All()
        {
            return Connection.Query<Model.Planning>("select * from Planning", transaction: Transaction).ToList();
        }
        public List<Model.Planning> All(DateTime fromDate,DateTime toDate)
        {
            return Connection.Query<Model.Planning, Model.Po, Model.Staff, Model.Planning>("GetPlanning", (pl, p, s) => { pl.Po = p; pl.Staff = s; return pl; }
                , new { @fromdate = fromDate, @todate = toDate },splitOn:"PoCode,StaffName",commandType:CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public List<Model.Planning> Search(string searchStr)
        {
            return Connection.Query<Model.Planning, Model.Po, Model.Staff, Model.Planning>("GetPlanningByName", (pl, p, s) => { pl.Po = p; pl.Staff = s; return pl; }
                , new { @searchStr = searchStr }, splitOn: "PoCode,StaffName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }
        public Model.Planning Find(Guid id)
        {
            return Connection.Query<Model.Planning>("select * from Planning where PlanningId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            Connection.Execute("delete from Planning where PlanningId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Planning entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.PlanningId);
        }

        public void Update(Model.Planning entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
//            string update = string.Format(@"update  Planning set PlanningId= @PlanningId,PlanningCode= @PlanningCode,PlanningName= @PlanningName,
//            StatusId= @StatusId,PoCode= @PoCode,LoadPo= @LoadPo,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,
//            ModifyBy= @ModifyBy where PlanningId = @PlanningId");
//            Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }
        public List<Model.QuotationDetail> GetAllProduct(string planningCode)
        {
            return Connection.Query<Model.QuotationDetail, Model.Product, Model.Unit, Model.QuotationDetail>("GetAllProductbyPlanning", (qd, p, u) => { qd.Product = p; p.Unit = u; return qd; }
                , param: new { @planningCode = planningCode }, splitOn: "ProductCode,UnitName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();

        }
        public void CreateFromPO(Po po)
        {
            string user = UserManagement.UserSession.UserName;
            Connection.Execute("CreatePlanningFromPO", new { @poCode = po.PoCode, @createBy = user }, commandType: CommandType.StoredProcedure, transaction: Transaction);
        }
        public void AddProductFromPOToPlanning(Planning planning, Po po)
        {
            Connection.Execute("AddProductFromPOToPlanning", new { @planningCode = planning.PlanningCode, poCode = po.PoCode }, commandType: CommandType.StoredProcedure, transaction: Transaction);
        }
    }

}
