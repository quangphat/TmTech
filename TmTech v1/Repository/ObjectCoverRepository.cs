using Dapper;
using System;
using System.Data;
using TmTech_v1.Model;
using TmTech_v1.Repository;
using TmTech_v1.Utility;

namespace TmTech_v1.Interface
{

    public interface IObjectCoverRepository : IGenericRepository<ObjectCover>
    {
        void DeleteById<T>(T entity, string idName);
        bool CheckCodeExist(ObjectCover obj);
        void Approve<T>(T entity, string idName, int approveStatus);
        void AddProductProperty<T>(T entity);
    }

 

    public class ObjectCover : CoreEntry
    {
        public string TableName { get; set; }
        public string PrimaryKeyName { get; set; }
        public string Code { get; set; }
    }
    public class ObjectCoverRepositroy : RepositoryBase<ObjectCover>, IObjectCoverRepository
    {
        public ObjectCoverRepositroy(IDbTransaction transaction)
            : base(transaction)
        {

        }

        public bool CheckCodeExist(ObjectCover obj)
        {
            return false;
        }

        public void DeleteById<T>(T entity,string idName)
        {
            string modelname = entity.GetType().Name;
            if (string.IsNullOrWhiteSpace(idName))
            {
                idName = modelname + "Id";
            }
            var propertyId = entity.GetType().GetProperty(idName);
            var valueId = propertyId.GetValue(entity);
            if (propertyId.PropertyType.Name.ToString() == "Int32")
                Connection.Execute("DeleteGenericById", new { @tablename = modelname, @primarykeyname = @idName, @intIdValue = valueId, @guidIdValue = Guid.Empty }, commandType: CommandType.StoredProcedure, transaction: Transaction);
            if (propertyId.PropertyType.Name.ToString() == "Guid")
            {
                Connection.Execute("DeleteGenericById", new { @tablename = modelname, @primarykeyname = idName, @intIdValue = 0, @guidIdValue = valueId }, commandType: CommandType.StoredProcedure, transaction: Transaction);
            }
        }


        public void Approve<T>(T entity, string idName,int approveStatus)
        {
            string modelname = entity.GetType().Name;
            if (string.IsNullOrWhiteSpace(idName))
            {
                idName = modelname + "Id";
            }
            var propertyId = entity.GetType().GetProperty(idName);
            var valueId = propertyId.GetValue(entity);
            string update = string.Empty;
            update = string.Format("update {0} set ApproveStatusId = {1},ApproveBy = '{2}',ApproveDate = '{3}' where {4} = '{5}'", modelname,approveStatus,UserManagement.UserSession.UserName,DateTime.Now.ToString("yyyy/MM/dd"), idName, valueId);
            Connection.Execute(update, transaction: Transaction);
        }


        public void AddProductProperty<T>(T entity)
        {
            string modelname = entity.GetType().Name;
            string columnValue = "Value";
            string value = CoverObjectUtility.GetPropertyValue(columnValue, entity).ToString();
            Guid productId = Guid.Parse(CoverObjectUtility.GetPropertyValue("ProductId", entity).ToString());
            string insert = string.Empty;
            insert = string.Format("insert into {0}(Value,ProductId) values ('{1}','{2}')", modelname,  value,productId);
            Connection.Execute(insert, transaction: Transaction);
        }
    }

}
