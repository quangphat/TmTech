using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmtech.Data.Interface;
using Tmtech.Data.Repository;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository objecRepository =new StudentRepository();
            var student = new Student()
            {
                Id =  Guid.NewGuid().ToString(),
                Name =  "Nguyen truong nghia",
                CreateBy =  "nhi",
                CreateDate = DateTime.Now,
                ModifyDate =  DateTime.Now
            };
            objecRepository.Insert(student);
            objecRepository.Comit();
            objecRepository.Delete(student);
            objecRepository.Insert(student);
          
            objecRepository.Comit();
            


        }
    }
}
