
using System.Collections.Generic;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Business
{
    public interface IBaseBusiness<T> where T : CoreEntry
    {
        void Insert(T entry);
        void Update(T entry);
        T GetbyId(string code);
        List<T> GetAll();
        void Delete(T entry);
    }
}
