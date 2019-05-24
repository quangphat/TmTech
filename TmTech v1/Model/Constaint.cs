
namespace TmTech_v1.Model
{
    public class DefautValueType
    {
        public const string DefautValuesDouble = "0";
        public const string DefautValuesFloat = "0";
        public const string DefautValuesInt = "0";
        public const string DefautValueString = "";
    }

    public class Status
    {
        public int StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public string Note { get; set; }
        public int? TypeId { get; set; }
    }

    public class StatusType
    {
        public int StatusTypeId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }


    public class SystemColor
    {
        public string Code { get; set; }
        public string HexCode { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }

    public class TableName
    {
        public string Name { get; set; }
    }

    public class StatusConfrim
    {
        public static string New = "New"; //
        public static string Cancel = "Cancel";//
        public static string Close = "Close";//
        public static string Processing = "Chờ xác nhận";
        public static string Approve = "Đã xác nhận";
        public static string Sent = "Sent";
    }

}
