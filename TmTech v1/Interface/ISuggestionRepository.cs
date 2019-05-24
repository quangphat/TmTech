using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface ISuggestionRepository
    {
        void Add(Suggestion entity);
        List<Suggestion> All();
        Suggestion Find(int id);
        void Remove(int id);
        void Remove(Suggestion entity);
        void Update(Suggestion entity);
    }
}
