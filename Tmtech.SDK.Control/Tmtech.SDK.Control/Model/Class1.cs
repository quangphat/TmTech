using System;

namespace Tmtech.SDK.Control.Model
{
   public class Test
    {
       public string Id { get; set; }
       public bool Name { get; set; }
       public DateTime Datetime { get; set; }
    }
    public enum TestOrderBy
    {
        Id,
        Name,
        Datetime
    }
}
