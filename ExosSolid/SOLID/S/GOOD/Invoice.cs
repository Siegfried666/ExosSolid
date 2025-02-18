using System.Net.Mail;

namespace EXOSSOLID.SOLID.S.GOOD
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        private Logger logger;
        private MailSender mailSender;

        public Invoice()
        {
            logger = new Logger();
            mailSender = new MailSender();
        }

        public void AddInvoice(string emailFrom, string emailTo, string eMailSubject, string emailBody)
        {
            try
            {
                logger.Info("Sending new email");

                MailMessage mailMessage = new MailMessage(emailFrom, emailTo, eMailSubject, emailBody);
                mailSender.SendInvoiceEmail(mailMessage);

            }
            catch (Exception ex)
            {
                //Error Logging
                logger.Error(ex.Message);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                logger.Error(ex.Message);
            }
        }
    }
}