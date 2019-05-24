using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TmTech.Core
{
   public class CoreEntry
    {
        protected CoreEntry()
        {

        }

        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
