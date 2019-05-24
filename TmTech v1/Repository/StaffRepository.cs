using System;
using System.Data;
using TmTech_v1.Interface;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class StaffRepository : RepositoryBase<Model.Staff>, IStaffRepository
    {
        public StaffRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.Staff entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Staff(StaffCode,StaffName,Phone,Email,Fax,Skype,Address,Birthday,BeginDate,DepartmentId,Position,UserId,CreateDate,CreateBy,ModifyDate,ModifyBy) values (@StaffCode,@StaffName,@Phone,@Email,@Fax,@Skype,@Address,@Birthday,@BeginDate,@DepartmentId,@Position,@UserId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            //Connection.Execute(insert, entity, Transaction);
            Insert(entity);
        }

        public List<Model.Staff> All()
        {
            return GetAll();
        }

        public Model.Staff Find(int id)
        {
            return Get(p => p.StaffId,id);
        }
        public List<Model.Staff> FindByDepartment(int departmentId)
        {
            return Connection.Query<Model.Staff, Model.Users, Model.UserGroup,Model.Staff>("sp_FindStaffbyDepartment", 
                (s, u, g) => { s.User = u; s.UserGroup = g; return s; }, new { @departmentId = departmentId },
                splitOn: "UserName,UserGroupName",commandType:CommandType.StoredProcedure
                , transaction: Transaction).ToList();
        }
        public void Remove(int id)
        {
            //Connection.Execute("DELETE FROM Staff WHERE StaffId = @Id", param: new { Id = id }, transaction: Transaction);
            Delete(p => p.StaffId, id);
        }

        public void Remove(Model.Staff entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //Remove(entity.StaffId);
            Delete(entity);
        }

        public void Update(Model.Staff entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  Staff set StaffCode= @StaffCode,StaffName= @StaffName,Phone= @Phone,Email= @Email,Fax= @Fax,Skype= @Skype,Address= @Address,Birthday= @Birthday,BeginDate= @BeginDate,DepartmentId= @DepartmentId,Position= @Position,UserId= @UserId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy where StaffId = @StaffId");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }

        public Model.Staff SearchStaff(string keysearch)
        {

            return Connection.Query<Model.Staff>("select *from Staff  where StaffName = @searchStr", new { searchStr = keysearch }, commandType: CommandType.Text, transaction: Transaction).FirstOrDefault();
        }



    }
}
