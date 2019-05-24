using System;
using System.Collections.Generic;
using Tmtech.Data;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Business
{
    public partial class BaseBusiness<T> : IBaseBusiness<T> where T : CoreEntry
    {
        private readonly IBaseRepository<T> _repository;
        public BaseBusiness(IBaseRepository<T> repository)
        {
            this._repository = repository;
        }

        public void Insert(T entry)
        {
            entry.Id = new Guid().ToString();
            entry.CreateBy = "Nguyễn tường nghia";
            entry.CreateDate = DateTime.UtcNow;
            _repository.Insert(entry);
            _repository.Comit();
        }
        public void Update(T entry)
        {
            _repository.Update(entry);
            _repository.Comit();
        }
        public T GetbyId(string id)
        {
            return _repository.GetById(id);

        }
        public List<T> GetAll()
        {
            return _repository.All();
        }
        public void Delete(T entry)
        {
            _repository.Delete(entry);
            _repository.Comit();
        }
    }
}
