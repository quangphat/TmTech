
using Autofac;
using Tmtech.Data.Repository;
using Tmtech.Data.Interface;
using Tmtech.Business.RepositoryBussiness;
using Tmtech.Business.IBussiness;

namespace Tmtech.Business
{
    public class Resolve
    {
        //data
        public Resolve(ContainerBuilder container)
        {
            //data
            container.RegisterType<StudentRepository>().As<IStudentRepository>();
            //buisiness:   
            container.RegisterType<StudentBusiness>().As<IStudentBussiness>();
        }
    }
}
