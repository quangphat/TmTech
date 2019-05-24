

namespace Tmtech.SDK.Control.Model
{
    public class Constraint
    {
        public const string FormatDateTime = "dd/MM/yyyy";
        public const string Approve = "Approve";
        public const string PassWordChar = "*";
    }

    public enum StatusFlag
    {
        Waiting = 1,
        Ok = 2, 
        Cancel = 3
    }
    public enum TmTechColor
    {
        Approved = 0x38b04a,
        Cancel = 0x455f73,
        Warning = 0xFF4821,
        GridviewRow = 0x90CAF9,
        Waiting = 0xEAFF92,
        Finish = 0x31a8d2,
        InProgress = 0x38b04a
    }
}
