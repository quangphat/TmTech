using System;
using System.Data;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using Dapper;
using System.Collections.Generic;
using System.Linq;
namespace TmTech_v1.Repository
{
    public class CompanyRepository : RepositoryBase<Company>,ICompanyRepository
    {
        public CompanyRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Company entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Company(CompanyCode,CompanyName,Address,Phone1,Phone2,Fax,Taxcode,SwiftCode,NumberOfEmployee,DebitValue,ParentCompanyId,Branch,TagetValue,Website,Email,Note,TypeId,CreateDate,CreateBy,ModifyDate,ModifyBy,isActive,PictureLogo,Photo) values (@CompanyCode,@CompanyName,@Address,@Phone1,@Phone2,@Fax,@Taxcode,@SwiftCode,@NumberOfEmployee,@DebitValue,@ParentCompanyId,@Branch,@TagetValue,@Website,@Email,@Note,@TypeId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@isActive,@PictureLogo,@Photo)");
            //Connection.Execute(insert, entity, Transaction);
            Insert(entity);
        }

        public List<Company> All()
        {
            return Connection.Query<Company, Deputy, CompanyClass, Company>(@"Select c.*,d.DeputyId,d.DeputyName,d.Address,d.Phone,d.Fax,d.Skype,d.Email,d.isMain,cc.CompanyClassCode,cc.CompanyClassRate
from Company c left join (select * from Deputy where IsMain =1) d on c.CompanyId = d.CompanyId left join CompanyClass cc on c.ClassId = cc.CompanyClassId
left join CompanyType ct on c.typeId = ct.CompanyTypeId ", (c, d, cc) => { c.MainDeputy = d; c.Class = cc; return c; }, splitOn: "DeputyId,CompanyClassCode", transaction: Transaction).ToList();
        }

        public Company Find(int id)
        {
            return Connection.Query<Company, Deputy,CompanyClass, Company>(@"
                                select * from Company c left join (select * from Deputy where IsActive = 1 and IsMain =1 and CompanyId = @Id) d
                                on c.CompanyId = d.CompanyId left join CompanyClass cc on c.ClassId = cc.CompanyClassId
                                where c.CompanyId = @Id", (c, d, cc) => { c.MainDeputy = d; c.Class = cc; return c; }, new { Id = id }, splitOn: "DeputyId,CompanyClassCode", transaction: Transaction).FirstOrDefault();
        }

        public void InActive(int id)
        {
            Connection.Execute("update Company set isActive ='0' where CompanyId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void InActive(Company entity)
        {
            if (entity == null)
           
                throw new ArgumentNullException("entity");
            Delete(entity);

        }

        public void Update(Company entity)
        {
           
            if (entity == null)throw new ArgumentNullException("entity");
            var update = string.Format(@"update  Company set Approver =@Approver, Accountant=@Accountant,AccountantPhone=@AccountantPhone, Status =@Status, ApproveDate=@ApproveDate,ApproveBy =@ApproveBy, ClassID =@ClassID, CompanyCode= @CompanyCode,CompanyName= @CompanyName,Address= @Address,Phone1= @Phone1, BankID =@BankID,Phone2= @Phone2,Fax= @Fax,Taxcode= @Taxcode,SwiftCode= @SwiftCode,NumberOfEmployee= @NumberOfEmployee,DebitValue= @DebitValue,Branch= @Branch,TagetValue= @TagetValue,Website= @Website,Email= @Email,Note= @Note,TypeId= @TypeId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,isActive= @isActive,PictureLogo =@PictureLogo,Photo =@Photo where 
                                             CompanyId = @CompanyId");
            //Connection.Execute(update, entity, transaction: Transaction);
            Edit(entity);
        }

        public int AddandGetCompanyId(Company entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Company(   Approver, Accountant,AccountantPhone,CompanyCode,CompanyName,Address,Phone1,Phone2,Fax,Taxcode,SwiftCode,NumberOfEmployee,DebitValue,ParentCompanyId,Branch,TagetValue,Website,Email,Note,TypeId,CreateDate,CreateBy,ModifyDate,ModifyBy,isActive,PictureLogo,Photo,BankID,ClassID)
            output inserted.CompanyId values ( @Approver,  @Accountant,@AccountantPhone,@CompanyCode,@CompanyName,@Address,@Phone1,@Phone2,@Fax,@Taxcode,@SwiftCode,@NumberOfEmployee,@DebitValue,@ParentCompanyId,@Branch,@TagetValue,@Website,@Email,@Note,@TypeId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@isActive,@PictureLogo,@Photo,@BankID ,@ClassID)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public int CheckExitCompany(Company entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"select  COUNT(*) from Company c  where c.Address like " + "'" + entity.Address+ "'" + " or c.Taxcode = " + "'" + entity.Taxcode + "'" +" or c.CompanyName = " + "'" + entity.CompanyName +"'");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }
        public List<Company> SearchCompany(string keysearch)
        {

            return Connection.Query<Company, Deputy, Company>("LookForCompany", (c, d) => { c.MainDeputy = d; return c; }, new { @searchStr = keysearch },splitOn:"DeputyId", commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public void EnableActive(int comPanyId)
        {
            Connection.Execute("update Company set isActive ='1' where CompanyId = @Id", param: new { Id = comPanyId }, transaction: Transaction);
        }

        public List<CompanyClass> AllClass()
        {
            return Connection.Query<CompanyClass>("select * from CompanyClass", transaction: Transaction).ToList();
        }
    }

   
}
