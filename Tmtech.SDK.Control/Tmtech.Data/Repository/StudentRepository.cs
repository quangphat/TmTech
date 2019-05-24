using System.Data;
using Tmtech.Data.Interface;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Data.Repository
{
    public partial class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(/*IDbTransaction transaction=null*/)
            : base(/*transaction*/)
        {
           
        }
    }
}
