using System;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using Dapper;
using System.Data;
using TmTech_v1.Model;namespace TmTech_v1.Repository
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepositor
    {
        public LocationRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Location entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlCreate>
            base.Insert(entity);
        }

        public List<Location> All()
        {
            //<SqlGetAll>
            return base.GetAll();
        }

        public Location Find(Guid id)
        {
            //<SqlFindById>
            return base.Get(p => p.LocationID, id);
        }

        public void Remove(Guid id)
        {
           //<SqlRemoveById>
            base.Delete(p => p.LocationID, id);
        }

        public void Remove(Location entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlRemove>
            base.Delete(entity);
        }

        public void Update(Location entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //<SqlUpdate>
            base.Edit(entity);
        }


    }

}

