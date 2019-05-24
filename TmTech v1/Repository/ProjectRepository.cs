using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class ProjectBaseRepository : RepositoryBase<Project>, IProjectBaseRepository
    {
        public ProjectBaseRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Project(ProjectCode,ProjectName,DrawingName,DateBegin,DateEnd,Sale,CreateDate,CreateBy,ModifyDate,ModifyBy,CompanyId,StatusId) values (@ProjectCode,@ProjectName,@DrawingName,@DateBegin,@DateEnd,@Sale,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@CompanyId,@StatusId)");
            Connection.Execute(insert, entity, Transaction);
        }

        public int AddandGetRequestPaymentId(Project entry)
        {
            throw new NotImplementedException();
        }

        public List<Model.Project> All()
        {
            return Connection.Query<Project,Staff,Company, Status,Project>("select pr.*,st.StaffName, com.CompanyName, s.StatusName from Project pr join Staff st on pr.Sale = st.StaffId join Company com on pr.CompanyId = com.CompanyId join Status s on pr.StatusId = s.StatusId",(pr,st,com,s)=> { pr.Staff = st;pr.Company = com; pr.Status = s; return pr; },splitOn:"StaffName,CompanyName,StatusName", transaction: Transaction).ToList();
        }

        public Model.Project Find(int id)
        {
            return Connection.Query<Model.Project>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from Project where ProjectId =@Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.ProjectId);
        }

        public void Update(Model.Project entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  Project set ProjectCode= @ProjectCode,ProjectName= @ProjectName,DrawingName= @DrawingName,DateBegin= @DateBegin,DateEnd= @DateEnd,Sale= @Sale,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,CompanyId= @CompanyId,StatusId= @StatusId where ProjectId = @ProjectId");
            Connection.Execute(update, entity, transaction: Transaction);
        }

        public List<Project> Find(DateTime begin, DateTime end)
        {
            return Connection.Query<Project, Staff, Company,Status,Project>("sp_FindProjectByDate", (pr, st, com,s) => { pr.Staff = st; pr.Company = com; pr.Status = s; return pr; }, new { @begin = begin, @end = end }, splitOn: "StaffName,CompanyName,StatusName", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
            
        }

        public string GetProjectCode(int companyId, DateTime createDate)
        {
            return Connection.Query<string>("select dbo.fn_CreateProjectCode(@companyId,@ngaytao)", new { @companyId = companyId, @ngaytao = createDate }, transaction: Transaction).FirstOrDefault();
        }

        public List<Status> GetAllStatus()
        {
            return Connection.Query<Status>("select * from Status", transaction: Transaction).ToList();
        }
    }

}
