namespace EXOSSOLID.SOLID.O.GOOD
{
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            var proposedamount = amount - 50;

            return proposedamount;
        }
    }
}