using System;
using System.Data;
using TmTech_v1.Interface;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class StaffPostionRepository : RepositoryBase<Model.StaffPosition>, IStaffPositionRepository
    {
        public StaffPostionRepository(IDbTransaction transaction) : base(transaction)
        {
        }

        public void Add(StaffPosition entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Connection.Query("insert into StaffPosition(StaffPositionCode,StaffPositionName) values (@StaffPositionCode,@StaffPositionName)", entity, transaction: Transaction);
        }

        public List<StaffPosition> All()
        {
            return Connection.Query<Model.StaffPosition>("Select * from StaffPosition", transaction: Transaction).ToList();
        }

        public StaffPosition Find(int id)
        {
            return Get(p => p.StaffPositionId, id);
        }

        public void Remove(int id)
        {
            Connection.Query("delete from StaffPosition where StaffPositionId =@Id", new { @Id = id }, transaction: Transaction);
        }

        public void Remove (StaffPosition entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            Remove(entity.StaffPositionId);
            //Delete(entity);
        }
        
        public void Update(StaffPosition entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  StaffPosition set StaffPositionCode= @StaffPositionCode,StaffPositionName= @StaffPositionName where StaffPositionId = @StaffPositionId");
            Connection.Execute(update, entity, transaction: Transaction);
            //Edit(entity);
        }

    }
}
