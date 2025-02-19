namespace EXOSSOLID.SOLID.I.GOOD
{
    class LiquidInkjetPrinter : IPrintTasks, IScanTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
