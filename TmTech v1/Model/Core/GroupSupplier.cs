using DapperExtensions.Mapper;



namespace TmTech_v1.Model
{
    public interface ICoreEntry
    {
        string Id { get; }

    }

    public interface IEntry
    {
        string TypeName { get; set; }
    }
    public class GroupSupplier : CoreEntry, ICoreEntry
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int ParentGroup { get; set; }
        public string Id
        {
            get { return GroupId.ToString(); }
            set
            {
                if (value != null)
                    GroupId = int.Parse(Id);
                else
                    GroupId = 0;
            }
        }

       public int ApproveStatusId { get; set; }
    }
    public sealed class GroupMapper : ClassMapper<GroupSupplier>
    {
        public GroupMapper()
        {
            Table("GroupSupplier");
            Map(p => p.Id).Ignore();
            AutoMap();
        }
    }

}
