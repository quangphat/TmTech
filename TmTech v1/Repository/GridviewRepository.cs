using System;
using System.Data;
using TmTech_v1.Interface;
namespace TmTech_v1.Repository
{
    public class GridviewRepository:RepositoryBase<Model.Company>,IGridViewRepository
    {
        public GridviewRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Remove<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
