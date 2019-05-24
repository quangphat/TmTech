using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class IncomeExpenseRepository : RepositoryBase<IncomeExpense>, IIncomeExpenseRepository
    {
        public IncomeExpenseRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.IncomeExpense entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into IncomeExpense(IncomeExpenseCode,No,BillNo,DepartmentId,StaffId,MoneyIn,MoneyOut,MoneyUse,MoneyBack,RegisterValue,Sign,Content,Value,NoteId,Description,Note,CreateDate,CreateBy,ModifyDate,ModifyBy,ProjectId,ApproveStatusId,ApproveDate,ApproveBy,PurposeSuggestionId) values (@IncomeExpenseCode,@No,@BillNo,@DepartmentId,@StaffId,@MoneyIn,@MoneyOut,@MoneyUse,@MoneyBack,@RegisterValue,@Sign,@Content,@Value,@NoteId,@Description,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@ProjectId,@ApproveStatusId,@ApproveDate,@ApproveBy,@PurposeSuggestionId)");
            Connection.Execute(insert, entity, transaction: Transaction);
            //Connection.Query(insert, new { @IncomeExpenseCode = entity.IncomeExpenseCode, @Type = entity.Type, @BillNo = entity.BillNo, @DepartmentId = entity.DepartmentId, @StaffId= entity.StaffId, @MoneyIn=entity.MoneyIn, @MoneyOut = entity.MoneyOut, @MoneyUse=entity.MoneyUse, @MoneyBack=entity.MoneyBack, @RegisterValue=entity.RegisterValue, @Sign=entity.Sign, @Content=entity.Content, @Value=entity.Content, @NoteId=entity.NoteId, @Description=entity.Description, @Note=entity.Note, @CreateDate=entity.CreateDate, @CreateBy=entity.CreateBy }, Transaction);
        }

        public List<Model.IncomeExpense> All()
        {
            string sql = string.Format(@"select ie.*, n.NoteCode, n.NoteName, d.DepartmentName, st.StaffName, pr.ProjectCode from IncomeExpense ie 
                                        left join NoteProjectDetail n on ie.NoteId = n.NoteId
                                        left join Department d on ie.DepartmentId = d.DepartmentId
                                        left join Staff st on ie.StaffId = st.StaffId
                                        left join Project pr on ie.ProjectId = pr.ProjectId");
            return Connection.Query<IncomeExpense, NoteProjectDetail, Department, Staff,Project,IncomeExpense>(sql, (ie, n, d, st, pr) => { ie.NoteProjectDetail = n; ie.Department = d; ie.Staff = st; ie.Project =pr ; return ie; },
                splitOn: "NoteCode,DepartmentName,StaffName, ProjectCode", transaction: Transaction).ToList();
        }

        public List<IncomeExpense> Find(DateTime dt)
        {
            string sql = string.Format(@"select ie.*, d.DepartmentName, st.StaffName, ps.PurposeName from IncomeExpense ie
                                        left join Department d on ie.DepartmentId = d.DepartmentId
                                        left join Staff st on ie.StaffId = st.StaffId
                                        left join PurposeSuggestion ps on ie.PurposeSuggestionId = ps.PurposeSuggestionId
                                        where format(ie.CreateDate,'dd-MM-yyyy') =format(@dt,'dd-MM-yyyy')");
            return Connection.Query<IncomeExpense, Department, Staff, PurposeSuggestion, IncomeExpense>(sql, (ie, d, st, ps) => { ie.Department = d; ie.Staff = st; ie.PurposeSuggestion = ps ; return ie; },
                new { @dt = dt }, splitOn: "DepartmentName,StaffName,PurposeName", transaction: Transaction).ToList();
        }

        public Model.IncomeExpense Find(int id)
        {
            return Connection.Query<Model.IncomeExpense>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from IncomeExpense where IncomeExpenseId = @IncomeExpenseId", param: new { @IncomeExpenseId = id }, transaction: Transaction);
        }

        public void Remove(Model.IncomeExpense entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.IncomeExpenseId);
        }

        public void Update(Model.IncomeExpense entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  IncomeExpense set IncomeExpenseCode= @IncomeExpenseCode,No= @No,BillNo= @BillNo,DepartmentId= @DepartmentId,StaffId= @StaffId,MoneyIn= @MoneyIn,MoneyOut= @MoneyOut,MoneyUse= @MoneyUse,MoneyBack= @MoneyBack,RegisterValue= @RegisterValue,Sign= @Sign,Content= @Content,Value= @Value,NoteId= @NoteId,Description= @Description,Note= @Note,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,ProjectId= @ProjectId,ApproveStatusId= @ApproveStatusId,ApproveDate= @ApproveDate,ApproveBy= @ApproveBy,PurposeSuggestionId= @PurposeSuggestionId where IncomeExpenseId = @IncomeExpenseId");
            Connection.Execute(update, entity, transaction: Transaction);
        }
        public IList<IncomeExpense> Search(string StrSearch)
        {
            return Connection.Query<IncomeExpense, Department, Staff, NoteProjectDetail, Project,IncomeExpense>("sp_SearchIncomeExpense", (ie, dep, st, npd, pr) => { ie.Department = dep; ie.Staff = st; ie.NoteProjectDetail = npd; ie.Project = pr; return ie; }, new { @StrSearch = StrSearch }, splitOn: "DepartmentName,StaffName,NoteCode,ProjectCode", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public decimal GetLastMoneyIn()
        {
            return Connection.Query<decimal>("select top 1 MoneyIn from IncomeExpense order by IncomeExpenseId desc ", transaction: Transaction).FirstOrDefault();
        }

        public int GetCurrentId()
        {
            return Connection.Query<int>("select top 1 IncomeExpenseId from IncomeExpense order by IncomeExpenseId desc", transaction: Transaction).FirstOrDefault();
        }

        public List<PurposeSuggestion> GetAllPurpose()
        {
            return Connection.Query<PurposeSuggestion>("select * from PurposeSuggestion", transaction: Transaction).ToList();
        }
    }

}
