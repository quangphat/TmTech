using System;
using TmTech_v1.Utility;

namespace TmTech_v1.Model
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
        public void SetCreate()
        {
            this.CreateBy = UserManagement.UserSession.UserName;
            this.CreateDate = DateTime.Now;
        }
        public void SetModify()
        {
            this.ModifyBy = UserManagement.UserSession.UserName;
            this.ModifyDate = DateTime.Now;
        }
    }
}
