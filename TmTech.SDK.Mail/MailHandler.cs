using System.Net;
using System.Net.Mail;

namespace TmTech.SDK.Mail
{
    public class MailHandler : IMailHandler
    {
        public  bool SendMail(InformationMailModel informationMail)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(informationMail.SendersAddress);
                msg.To.Add(informationMail.ReceiverAddress);
                msg.Subject = informationMail.Subject;
                msg.Body = informationMail.Content;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(informationMail.SendersAddress, informationMail.SenderPassword);
                smtp.EnableSsl = true;
                smtp.Send(msg);
                return true;
            }
            catch 
            {
                return false;
            }


        }

       
    }
}
