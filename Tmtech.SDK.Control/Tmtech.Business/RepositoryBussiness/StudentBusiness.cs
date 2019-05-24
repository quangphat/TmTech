using Tmtech.Business.IBussiness;
using Tmtech.Data.Interface;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Business.RepositoryBussiness
{
    public partial class StudentBusiness : BaseBusiness<Student>, IStudentBussiness
    {
        private readonly IStudentRepository IstudentBussiness;
        public StudentBusiness(IStudentRepository repository) : base(repository)
        {
            IstudentBussiness = repository;
        }
    }
}
