namespace TmTech.SDK.Mail
{
   public class InformationMailModel
    {
        public string SendersAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public string SenderPassword { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
