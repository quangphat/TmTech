using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ISeriesPartBaseRepository : IBaseRepository<SeriesPart>
    {
        List<SeriesPart> FindByTypeID(int ID);
    }

    public interface ISourcingBaseRepository : IBaseRepository<Sourcing>
    {
        Sourcing FindPartByIDPart(int ID);        

    }
    public interface IPartBaseRepository : IBaseRepository<Part>
    {
        List<Part> FindBySeriesPartID(int ID);
        List<ViewSupplierSourcing> PartOfSupplier(string querry);
       

    }
} 