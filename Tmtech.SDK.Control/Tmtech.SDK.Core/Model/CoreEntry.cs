using System;

namespace Tmtech.SDK.Core.Model
{
    public class CoreEntry : IIdentityEntity
    {

        public string CreateBy { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string Id { get; set; }
        protected CoreEntry()
        {

        }
    }

    public interface IIdentityEntity
    {
        string Id { get; set; }
    }

    public enum CoreEntryOrderBy
    {
        Id
    }
}
