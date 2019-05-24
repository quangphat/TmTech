using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ICategoryRepository
    {
        void Add(Category entity);
        List<Category> All();
        List<Category> Own();
        List<Category> AllRootCategory();
        List<Category> FindByParentId(int rootId);
        bool FindExist(Category entity);
        Category Find(int id);
        void Remove(int id);
        void Remove(Category entity);
        void Update(Category entity);
    }

}
