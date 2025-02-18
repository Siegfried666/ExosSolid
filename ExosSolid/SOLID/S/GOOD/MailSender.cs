
using System.Net.Mail;
using EXOSSOLID.SOLID.S.GOOD.Interface;

namespace EXOSSOLID.SOLID.S.GOOD
{
    public class MailSender : IMailSender
    {
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            Console.WriteLine($"Sending Email... Subject: {mailMessage.Subject}, From: {mailMessage.From}, To: {mailMessage.To}, Body: {mailMessage.Body}  ");
        }
    }

}

