using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        public SupplierRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Supplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //string insert = string.Format(@"insert into Company(CompanyCode,CompanyName,Address,Phone1,Phone2,Fax,Taxcode,SwiftCode,NumberOfEmployee,DebitValue,ParentCompanyId,Branch,TagetValue,Website,Email,Note,TypeId,CreateDate,CreateBy,ModifyDate,ModifyBy,isActive,PictureLogo,Photo) values (@CompanyCode,@CompanyName,@Address,@Phone1,@Phone2,@Fax,@Taxcode,@SwiftCode,@NumberOfEmployee,@DebitValue,@ParentCompanyId,@Branch,@TagetValue,@Website,@Email,@Note,@TypeId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@isActive,@PictureLogo,@Photo)");
            //Connection.Execute(insert, entity, Transaction);
            Insert(entity);
        }

        public int CheckExitSuplier(Supplier entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"select  COUNT(*) from Supplier c  where c.Address like " + "'" + entity.Address + "'" + " or c.SupplierName = " + "'" + entity.SupplierName + "'");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }


        public List<Supplier> All()
        {
            return Connection.Query<Supplier, SubSupplier, CompanyClass, Supplier>(@"Select c.*,d.SubSupplierId,d.SubSupplierName,d.Address,d.Phone,d.Fax,d.Skype,d.Email,d.isMain,cc.CompanyClassCode,cc.CompanyClassRate
from Supplier c left join (select * from SubSupplier where IsMain =1) d on c.SupplierId = d.SupplierId left join CompanyClass cc on c.ClassId = cc.CompanyClassId
left join CompanyType ct on c.typeId = ct.CompanyTypeId ", (c, d, cc) => { c.SubSupplier = d; c.Class = cc; return c; }, splitOn: "SubSupplierId,CompanyClassCode", transaction: Transaction).ToList();
        }

        public Supplier Find(int id)
        {
            return Connection.Query<Supplier, Model.Users, Model.Staff, Supplier>("GetDataSuppplierID", (c, u, s) => { c.User = u; c.Staff = s; return c; }, param: new { @SupplierId = id }, splitOn: "UserId,StaffId", commandType: CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int supplierId)
        {
            Connection.Execute("delete from Supplier where SupplierId = @SupplierId ", param: new { SupplierId = supplierId }, transaction: Transaction);
        }
     
        public void Remove(Supplier supplierRemove)
        {
            if (supplierRemove == null)
                throw new ArgumentNullException("entity");

            base.Delete(supplierRemove);
        }

        public void Update(Supplier supplierUpdate)
        {
            //if (supplierUpdate == null)
            //    throw new ArgumentNullException("entity");
            //string update = string.Format(@"update  Supplier set SupplierCode= @SupplierCode,SupplierName= @SupplierName,Address= @Address,Phone= @Phone,Fax= @Fax,Taxcode= @Taxcode,BankAccount= @BankAccount,SwiftCode= @SwiftCode,Branch= @Branch,TagetValue= @TagetValue,Website= @Website,Email= @Email,Note= @Note,TypeId= @TypeId,CreateDate= @CreateDate,CreateBy= @CreateBy,ModifyDate= @ModifyDate,ModifyBy= @ModifyBy,ApproveStatusId= @ApproveStatusId,Photo= @Photo,PictureLogo= @PictureLogo,BankName= @BankName,GroupId= @GroupId,ApproveDate= @ApproveDate,ApproveBy= @ApproveBy,AccountantPhone= @AccountantPhone,Accountant= @Accountant,Status= @Status,isActive= @isActive,Approver= @Approver where SupplierId  =@SupplierId");
            //Connection.Execute(update, supplierUpdate, transaction: Transaction);
            base.Edit(supplierUpdate);
        }

        public List<Supplier> searchSupplier(string keysearch)
        {
            return Connection.Query<Supplier>("LookForSupplier", new { @searchStr = keysearch }, commandType: CommandType.StoredProcedure, transaction: Transaction).ToList();
        }

        public int AddandGetSupplierID(Supplier supplierInsert)
        {
            if (supplierInsert == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Supplier(Status,ApproveDate,ApproveBy,Approver,ApproveStatusId, SupplierCode,SupplierName,Address,Phone,Fax,Taxcode,SwiftCode,Branch,TagetValue,Website,Email,Note,TypeId,CreateDate,CreateBy,ModifyDate,ModifyBy,isActive,Photo,PictureLogo,GroupID)  output inserted.SupplierId values (@Status,@ApproveDate,@ApproveBy,@Approver,@ApproveStatusId,@SupplierCode,@SupplierName,@Address,@Phone,@Fax,@Taxcode,@SwiftCode,@Branch,@TagetValue,@Website,@Email,@Note,@TypeId,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy,@isActive,@Photo,@PictureLogo,@GroupID)");
            return Connection.ExecuteScalar<int>(insert, supplierInsert, Transaction);
        }

        public void EnableActive(int supplierId)
        {
            Connection.Execute("update Supplier set isActive ='1'  where   SupplierId =@Id ", param: new { Id = supplierId }, transaction: Transaction);
        }
        public void DeleteGroupSupplier(int GroupID)
        {
            Connection.Execute("delete  from GroupSupplier where GroupID =  @GroupID ", param: new { GroupID = GroupID }, transaction: Transaction);
        }

        public void DisableActive(int supplierId)
        {
            Connection.Execute("update Supplier set isActive ='0'  where   SupplierId =@Id ", param: new { Id = supplierId }, transaction: Transaction);
        }
        public void Updategroupsupplier(GroupSupplier groupsupplier)
        {
            Connection.Execute("update GroupSupplier set GroupName  =@GroupName, ApproveStatusId =@ApproveStatusId where GroupID =   @GroupID ", param: new { GroupID = groupsupplier.GroupId, GroupName=  groupsupplier.GroupName , ApproveStatusId =groupsupplier.ApproveStatusId }, transaction: Transaction);
        }
        public Supplier FindByGroupSupplierID(int id)
        {
            return Connection.Query<Supplier, Model.Users, Model.Staff, Supplier>("GetDataGroupID", (c, u, s) => { c.User = u; c.Staff = s; return c; }, param: new { @GroupId = id }, splitOn: "UserId,StaffId", commandType: CommandType.StoredProcedure, transaction: Transaction).FirstOrDefault();
        }

        public GroupSupplier FindGroupName(string groupname)
        {
            return Connection.Query<GroupSupplier>("select * from GroupSupplier where GroupName  like @groupname1", param: new { groupname1 = groupname }, transaction: Transaction).FirstOrDefault();
        }

        public GroupSupplier FindGroupID(int groupid)
        {
            return Connection.Query<GroupSupplier>("select  * from GroupSupplier where GroupID = @GroupID", param: new { GroupID = groupid }, transaction: Transaction).FirstOrDefault();
        }
       public void deletegroup(GroupSupplier m_groupsupplier)
        {
            string delete = ("delete from GroupSupplier  where GroupID = " + m_groupsupplier.GroupId);
            Connection.Execute("delete from GroupSupplier  where GroupID  =@GroupID", param: new { GroupID = m_groupsupplier.GroupId }, transaction: Transaction);
            
        }
        public int AddGroup(GroupSupplier groupsupplier)
        {
            string insert = (" insert into GroupSupplier(GroupName, ParentGroup) output inserted.GroupID values(@GroupName, @ParentGroup)");

            return Connection.ExecuteScalar<int>(insert, groupsupplier, Transaction);
        }

        public Supplier Findsupplier(int id)
        {
            return Connection.Query<Supplier, SubSupplier, Supplier>(@"
                                select * from Supplier c left join (select * from SubSupplier where IsActive = 1 and IsMain =1) d
                                on c.SupplierId = d.SupplierId
                                where c.SupplierId = @Id", (c, d) => { c.SubSupplier = d; return c; }, new { Id = id }, splitOn: "SupplierId", transaction: Transaction).FirstOrDefault();
        }

       
    }

}
