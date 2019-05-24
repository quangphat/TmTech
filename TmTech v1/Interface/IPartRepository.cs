using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public  interface ITypePartBaseRepository  : IBaseRepository<TypePart>

    {
        List<TypePart> FindByGroupID(int ID);

        
    }
    public interface IGroupPartBaseRepository : IBaseRepository<GroupPart>
    {

        bool FindExist(GroupPart entity);
    }

    

   

   

}
