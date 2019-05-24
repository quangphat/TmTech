using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions.Mapper;
using Tmtech.SDK.Core.Model;

namespace Tmtech.Data.ClassMapper
{
  public class StudentMapper : ClassMapper<Student>
    {
        public StudentMapper()
        {
            Table("Student");
            AutoMap();
        }
    }
}
