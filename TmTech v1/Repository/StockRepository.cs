using System.Data;
using TmTech_v1.Interface;

namespace TmTech_v1.Repository
{
    public class StockRepository : RepositoryBase<Model.Stock>, IStockRepository
    {
        public StockRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }

       
    }

}
