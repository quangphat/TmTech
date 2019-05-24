using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;
namespace TmTech_v1.Repository
{
    public class SubSupplierRepository : RepositoryBase<SubSupplier>, ISubSupplierRepository
    {
        public SubSupplierRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.SubSupplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into SubSupplier(SubSupplierCode,SubSupplierName,SupplierId,Address,Phone,Birthday,Fax,Skype,Email,Note,StaffId,UserId,CreateDate,CreateBy,ModifyDate,ModifyBy,IsActive,IsMain,Sex) values (@SubSupplierCode,@SubSupplierName,@SupplierId,@Address,@Phone,@Birthday,@Fax,@Skype,@Email,@Note,@StaffId,@UserId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@IsActive,@IsMain,@Sex)");
            //Connection.Execute(insert, entity, Transaction);
            base.Insert(entity);
        }

        public List<Model.SubSupplier> All()
        {
            return null;
            //return Connection.Query<Model.Deputy,Model.Company,Model.Deputy>("Select * from Deputy d inner join Company c on d.SupplierId = c.SupplierId where ComapnyId =@SupplierId", transaction: Transaction).ToList();
        }

        public Model.SubSupplier Find(int id)
        {
            return Connection.Query<Model.SubSupplier>("select  * from  SubSuplier where SubSupplierId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }
        public Model.SubSupplier Find(string Account)
        {
            return Connection.Query<Model.SubSupplier>("select * from  SubSuplier inner join Users on SubSupplier.UserId = Users.UserId and  Users.UserName = @Id", param: new { Id = Account }, transaction: Transaction).FirstOrDefault();

        }
        public Model.SubSupplier FindMainSubsupplier(int id)
        {
            return Connection.Query<Model.SubSupplier>("select  * from SubSupplier    where IsMain = 1 and  SupplierId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("update  SubSupplier set SubSupplierCode= @SubSupplierCode,SubSupplierName= @SubSupplierName,SupplierId= @SupplierId,Address= @Address,Phone= @Phone,Birthday= @Birthday,Fax= @Fax,Skype= @Skype,Email= @Email,Note= @Note,StaffId= @StaffId,UserId= @UserId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,IsActive= @IsActive,IsMain= @IsMain,Sex= @Sex where SubSupplierId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(Model.SubSupplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

        }

        public void Update(Model.SubSupplier entity)
        {

            if (entity == null)
                throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  SubSupplier set SubSupplierCode= @SubSupplierCode,SubSupplierName= @SubSupplierName,SupplierId= @SupplierId,Address= @Address,Phone= @Phone,Birthday= @Birthday,Fax= @Fax,Skype= @Skype,Email= @Email,Note= @Note,StaffId= @StaffId,UserId= @UserId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,IsActive= @IsActive,IsMain= @IsMain,Sex= @Sex  where  SubSupplierId = @SubSupplierId  ");
            //Connection.Execute(update, entity, transaction: Transaction);
            base.Edit(entity);
        }

        public void UnckeckMain(int supplierId, int  numbertrue)
        {
            Connection.Execute("update SubSupplier set IsMain =@numbertrue1  where   SupplierId =@Id ", param: new { Id = supplierId, numbertrue1 = numbertrue }, transaction: Transaction);
        }

        public bool AllowUpdateIsmain(int supplierId)
        {
            var allow=  Connection.ExecuteScalar<int>("	select count(*) from SubSupplier where SupplierId = @SupplierId", param: new { SupplierId = supplierId }, transaction: Transaction);
            return (allow > 1);
        }

        public List<SubSupplier> GetBySupplierID(int SupplierId)
        {


            return Connection.Query<Model.SubSupplier, Supplier, Model.SubSupplier>("Select d.*, c.SupplierName from SubSupplier d inner join Supplier c on d.SupplierId = c.SupplierId where d.SupplierId =@SupplierId  order by  d.IsMain DESC ", (d, c) => { d.Supplier = c; return d; }, new { @SupplierId = SupplierId }, splitOn: "SupplierName", transaction: Transaction).ToList();

        }

        public List<SubSupplier> GetbySupplier(Supplier company)
        {
            return Connection.Query<SubSupplier, Supplier, Users, SubSupplier>(@"Select d.*,c.SupplierName,u.* from SubSupplier d 
            inner join Supplier c on d.SupplierId = c.SupplierId 
			inner join Users u on d.UserId = u.UserId 
			where d.SupplierId =@SupplierId order by d.IsMain desc"
                , (d, c, u) => { d.Supplier = c; d.User = u; return d; }, new { @SupplierId = company.SupplierId }
                , splitOn: "SupplierName,UserName", transaction: Transaction).ToList();
        }
    }

}
