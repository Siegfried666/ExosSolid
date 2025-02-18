using System.Net.Mail;

namespace EXOSSOLID.SOLID.S.BAD
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Invoice()
        {
        }

        public void AddInvoice(string emailFrom, string emailTo, string eMailSubject, string emailBody)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(emailFrom, emailTo, eMailSubject, emailBody);
                this.SendInvoiceEmail(mailMessage);

            }
            catch (Exception ex)
            {
                //Error Logging
                Console.WriteLine(ex.ToString());
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
                Console.WriteLine(ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail

                Console.WriteLine($"Sending Email... Subject: {mailMessage.Subject}, From: {mailMessage.From}, To: {mailMessage.To}, Body: {mailMessage.Body}  ");
            }
            catch (Exception ex)
            {
                //Error Logging
                Console.WriteLine(ex.ToString());
            }
        }
    }
}