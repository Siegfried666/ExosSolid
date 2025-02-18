namespace EXOSSOLID.SOLID.O.BAD
{
    //BAD: ici on a implémenté InvoiceType dans la même classe, si demain on veut ajouter un autre type, on est obligé de modifier la classe complète ! 
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
}
