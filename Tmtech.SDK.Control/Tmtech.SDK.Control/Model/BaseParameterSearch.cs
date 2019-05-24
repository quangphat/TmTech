
using System;

namespace Tmtech.SDK.Control.Model
{
   public class BaseParameterSearch
    {
       public string Token { get; set; }
       public int PageSize { get; set; }
       public int PageIndex { get; set; }
       public DateTime? CreateDateTime { get; set; }
       public DateTime? LastUpdateTime { get; set; }
    }
}
