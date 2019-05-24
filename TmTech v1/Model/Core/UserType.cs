namespace TmTech_v1.Model
{
    public class UserType :CoreEntry
    {
        public int Id { get; set; }
        public int UserTypeId { get { return Id; } }
        public string UserTypeCode { get; set; }
        public string UserTypeName { get; set; }

    }

    public static class UserConstant
    {

        public static int CUSTOMER_Group = 2;
        public static int  EMPLPOY_TYPE = 1; 
    }
}
