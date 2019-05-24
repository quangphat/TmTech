using System;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using TmTech_v1.Interface;
using TmTech_v1.Model;

namespace TmTech_v1.Repository
{
    public class NoteProjectDetailBaseRepository : RepositoryBase<Model.NoteProjectDetail>, INoteProjectDetailBaseRepository
    {
        public NoteProjectDetailBaseRepository(IDbTransaction transaction)
            : base(transaction)
        {
        }
        public void Add(Model.NoteProjectDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string insert = string.Format(@"insert into NoteProjectDetail(NoteCode,NoteName) values (@NoteCode,@NoteName)");
            Connection.Execute(insert, entity, Transaction);
        }

        public int AddandGetRequestPaymentId(NoteProjectDetail entry)
        {
            throw new NotImplementedException();
        }

        public List<Model.NoteProjectDetail> All()
        {
            return Connection.Query<Model.NoteProjectDetail>("select * from NoteProjectDetail", transaction: Transaction).ToList();
        }

        public Model.NoteProjectDetail Find(int id)
        {
            return Connection.Query<Model.NoteProjectDetail>("", param: new { Id = id }, transaction: Transaction).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Connection.Execute("delete from NoteProjectDetail where NoteId = @NoteId", param: new { @NoteId = id }, transaction: Transaction);
        }

        public void Remove(Model.NoteProjectDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            Remove(entity.NoteId);
        }

        public void Update(Model.NoteProjectDetail entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            string update = string.Format(@"update  NoteProjectDetail set NoteCode= @NoteCode,NoteName= @NoteName where NoteId = @NoteId");
            Connection.Execute(update, entity, transaction: Transaction);
        }


    }

}
