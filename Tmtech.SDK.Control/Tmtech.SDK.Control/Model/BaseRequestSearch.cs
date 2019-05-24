using System;
using System.Collections.Generic;



namespace Tmtech.SDK.Control.Model
{
   public class BaseRequestSearch
    {
        public List<string> lstColumnFilter { get; set; }
        public DateTime? DtpFrom { get; set; }
        public DateTime? DtpTo { get; set; }
        public string Table { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public SortType sortType { get; set; }

    }
}
