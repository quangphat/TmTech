using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;
namespace TmTech_v1.Repository
{
    public class GroupPartBaseRepository : RepositoryBase<Model.GroupPart>, IGroupPartBaseRepository
    {
        public GroupPartBaseRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public void Add(GroupPart entry)
        {
            throw new NotImplementedException();
        }

        public Guid AddGetId(GroupPart entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into GroupPart(GroupPartCode,GroupPartName,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.GroupPartId values  (@GroupPartCode,@GroupPartName,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            return Connection.ExecuteScalar<Guid>(insert, entity, Transaction);
        }

        public int AddandGetRequestPaymentId(GroupPart entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into GroupPart(GroupPartCode,GroupPartName,Note,CreateDate,CreateBy,ModifyDate,ModifyBy) output inserted.GroupPartId values  (@GroupPartCode,@GroupPartName,@Note,@CreateDate,@CreateBy,@ModifyDate,@ModifyBy)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<GroupPart> All()
        {
            return base.GetAll();
        }

        public GroupPart Find(int id)
        {
            return Connection.Query<Model.GroupPart>("select * from GroupPart where GroupPartId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();

        }

        public bool FindExist(GroupPart entity)
        {
            List<GroupPart> lstCategory;
            lstCategory = Connection.Query<Model.GroupPart>("select * from GroupPart where GroupPartCode  = @GroupPartCode and GroupPartId <>@Id", new { GroupPartCode = entity.GroupPartCode, Id = entity.GroupPartId }, transaction: Transaction).ToList();
            if (lstCategory == null || lstCategory.Count > 0)
                return true;
            return false;
        }

        public void Remove(GroupPart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from  GroupPart where GroupPartId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Update(GroupPart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }

     
    
    }
    public class TypePartBaseRepository : RepositoryBase<Model.TypePart>, ITypePartBaseRepository
    {
        public TypePartBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(TypePart entry)
        {
            throw new NotImplementedException();
        }


        public int AddandGetRequestPaymentId(TypePart entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into TypePart(TypePartCode,TypePartName,GroupPartId,Note,CreateBy,CreateDate,ModifyBy,ModifyDate) output inserted.TypePartID values (@TypePartCode,@TypePartName,@GroupPartId,@Note,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<TypePart> All()
        {
            return base.GetAll();
        }


        public TypePart Find(int id)
        {
            return Connection.Query<Model.TypePart>("select * from TypePart where TypePartID = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();

        }

        public List<TypePart> FindByGroupID(int id)
        {
            return base.FindbyParentId(p => p.GroupPartId,id);
        }

        public void Remove(TypePart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Remove(Guid id)
        {
            Connection.Execute("delete from TypePart where TypePartID = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from TypePart where TypePartID = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Update(TypePart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }
    }
    public class SeriesPartBaseRepository : RepositoryBase<Model.SeriesPart>, ISeriesPartBaseRepository
    {
        public SeriesPartBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(SeriesPart entry)
        {
            throw new NotImplementedException();
        }

        public int AddandGetRequestPaymentId(SeriesPart entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into SeriesPart(SeriesPartCode,SeriesPartName,TypePartId,Note,CreateBy,CreateDate,ModifyBy,ModifyDate) output  inserted.SeriesPartId  values (@SeriesPartCode,@SeriesPartName,@TypePartId,@Note,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<SeriesPart> All()
        {
            return base.GetAll();
        }

        public SeriesPart Find(int id)
        {
            return Connection.Query<Model.SeriesPart>("select * from SeriesPart where SeriesPartId = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public List<SeriesPart> FindByTypeID(int id)
        {
            return Connection.Query<Model.SeriesPart>("select * from SeriesPart where TypePartId = @Id", param: new { Id = id }, transaction: Transaction).ToList();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from SeriesPart where SeriesPartId  = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Remove(SeriesPart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Update(SeriesPart entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }
    }
    public class SourcingBaseRepository : RepositoryBase<Model.Sourcing>, ISourcingBaseRepository
    {
        public SourcingBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(Sourcing entry)
        {
            throw new NotImplementedException();
        }

        public int AddandGetRequestPaymentId(Sourcing entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Sourcing(Note,CreateBy,CreateDate,ModifyBy,ModifyDate,PartID,SupplierID) output inserted.SouringID values (@Note,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate,@PartID,@SupplierID)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<Sourcing> All()
        {
            return base.GetAll();
        }

        public Sourcing Find(int id)
        {
            return Connection.Query<Model.Sourcing>("select * from Sourcing where SouringID = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public Sourcing FindPartByIDPart(int id)
        {
            return Connection.Query<Model.Sourcing>("select * from Sourcing where PartID = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(Sourcing entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            base.Delete(entity);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sourcing entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }
    }
    public class PartBaseRepository : RepositoryBase<Model.Part>, IPartBaseRepository
    {
        public PartBaseRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(Part entry)
        {
            throw new NotImplementedException();
        }

        public int AddandGetRequestPaymentId(Part entity)
        {
            if (entity == null)

                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into Part(Description,ImagePath,Pricespart,CreateBy,CreateDate,ModifyBy,ModifyDate,SeriesPartID,partName,PartNumber) output inserted.PartID values (@Description,@ImagePath,@Pricespart,@CreateBy,@CreateDate,@ModifyBy,@ModifyDate,@SeriesPartID,@partName,@PartNumber)");
            return Connection.ExecuteScalar<int>(insert, entity, Transaction);
        }

        public List<Part> All()
        {
            return base.GetAll();
        }

        public Part Find(int id)
        {
        
                return Connection.Query<Model.Part>("select * from Part where PartID = @Id", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
            
        }

        public List<Part> FindBySeriesPartID(int id)
        {
            return base.FindbyParentId(p => p.SeriesPartID, id);
        }

        public List<ViewSupplierSourcing> PartOfSupplier(string querry)
        {
            return Connection.Query<ViewSupplierSourcing>(querry, commandType: CommandType.Text, transaction: Transaction).ToList();
        }

        public void Remove(Part entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Delete(entity);
        }

        public void Remove(int id)
        {
            Connection.Execute("update Company set isActive ='0' where CompanyId = @Id", param: new { Id = id }, transaction: Transaction);
        }

        public void Update(Part entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            base.Edit(entity);
        }
    }
}