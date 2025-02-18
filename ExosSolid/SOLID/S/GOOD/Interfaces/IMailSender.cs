using System.Net.Mail;

namespace EXOSSOLID.SOLID.S.GOOD.Interface
{
    public interface IMailSender
    {
        void SendInvoiceEmail(MailMessage mailMessage);

    }
}
