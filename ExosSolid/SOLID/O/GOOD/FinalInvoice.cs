namespace EXOSSOLID.SOLID.O.GOOD
{
    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            var finalAmount = amount - 100;

            return finalAmount;
        }
    }
}