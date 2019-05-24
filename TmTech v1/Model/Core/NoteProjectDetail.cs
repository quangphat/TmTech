using DapperExtensions.Mapper;

namespace TmTech_v1.Model
{
    public class NoteProjectDetail:CoreEntry
    {
        public int NoteId { get; set; }
        public string NoteCode { get; set; }
        public string NoteName { get; set; }
    }

    public class NoteProjectDetailMapper: ClassMapper<NoteProjectDetail>
    {
        public NoteProjectDetailMapper()
        {
            Table("NoteProjectDetail");
            Map(p => p.CreateDate).Ignore();
            Map(p => p.CreateBy).Ignore();
            Map(p => p.ModifyBy).Ignore();
            Map(p => p.ModifyDate).Ignore();
            AutoMap();
        }
    }
}
