/*
SRP Single Responsability Principle: une classe doit avoir une seule responsabilité
*/

//BAD: Dans le mauvais exemple, on doit modifier la classe complète Invoice si on choisi de modifier le logging par exemple
var from = "frederic@gmail.com";
var to = "romain@gmail.com";
var subject = "envoi de mail";
var body = "Ceci est un test d'envoi d'email";

EXOSSOLID.SOLID.S.BAD.Invoice invoiceBad = new EXOSSOLID.SOLID.S.BAD.Invoice();
invoiceBad.AddInvoice(from, to, subject, body);

//GOOD: L'envoi du mail doit être séparé de la classe Invoice et le logging aussi
EXOSSOLID.SOLID.S.GOOD.Invoice invoiceGood = new EXOSSOLID.SOLID.S.GOOD.Invoice();

invoiceGood.AddInvoice(from, to, subject, body);

/*
OCP Open-Closed Principle: On doit pouvoir ajouter des fonctionnalités à un composant sans en altérer le fonctionnement
*/

//BAD: 
EXOSSOLID.SOLID.O.BAD.Invoice invoiceBad2 = new EXOSSOLID.SOLID.O.BAD.Invoice();
Console.WriteLine("Bad final Invoice result with 150: " + invoiceBad2.GetInvoiceDiscount(150, EXOSSOLID.SOLID.O.BAD.InvoiceType.FinalInvoice));
Console.WriteLine("Bad proposed Invoice result with 200: " + invoiceBad2.GetInvoiceDiscount(200, EXOSSOLID.SOLID.O.BAD.InvoiceType.ProposedInvoice));

//GOOD:
EXOSSOLID.SOLID.O.GOOD.Invoice finalInvoice = new EXOSSOLID.SOLID.O.GOOD.FinalInvoice();
Console.WriteLine("Good final Invoice result with 150: " + finalInvoice.GetInvoiceDiscount(150));

EXOSSOLID.SOLID.O.GOOD.Invoice proposedInvoice = new EXOSSOLID.SOLID.O.GOOD.ProposedInvoice();
Console.WriteLine("Good proposed Invoice result with 200: " + proposedInvoice.GetInvoiceDiscount(200));

/*
LSP Liskov Substitution Principle: On doit pouvoir substituer une superclasse par ses classes enfants sans affecter le comportement de la superclasse
*/

//BAD: 
EXOSSOLID.SOLID.L.BAD.Apple appleBad = new EXOSSOLID.SOLID.L.BAD.Orange();
Console.WriteLine(appleBad.GetColor());

//GOOD:
EXOSSOLID.SOLID.L.GOOD.Fruit appleGood = new EXOSSOLID.SOLID.L.GOOD.Apple();
Console.WriteLine(appleGood.GetColor());

EXOSSOLID.SOLID.L.GOOD.Fruit orangeGood = new EXOSSOLID.SOLID.L.GOOD.Orange();
Console.WriteLine(orangeGood.GetColor());

/*
ISP Interface Segregation Principle: On ne doit pas forcer à implémenter des méthodes qui ne seront pas utilisées. Pour cela on doit subdiviser les interfaces avec trop de 
méthodes en plus petites méthodes qu'on pourra implémenter séparémment.
*/

//BAD: 
EXOSSOLID.SOLID.I.BAD.HPLaserJetPrinter hPLaserJetPrinterBad = new EXOSSOLID.SOLID.I.BAD.HPLaserJetPrinter();
hPLaserJetPrinterBad.Print("print content");
hPLaserJetPrinterBad.Fax("fax content");
hPLaserJetPrinterBad.PrintDuplex("printduplex content");
hPLaserJetPrinterBad.Scan("scan content");

EXOSSOLID.SOLID.I.BAD.LiquidInkjetPrinter liquidInkjetPrinterBad = new EXOSSOLID.SOLID.I.BAD.LiquidInkjetPrinter();
liquidInkjetPrinterBad.Fax("fax content"); // NOK ! Unhandled exception. System.NotImplementedException: The method or operation is not implemented.

//GOOD:
EXOSSOLID.SOLID.I.GOOD.HPLaserJetPrinter hPLaserJetPrinterGood = new EXOSSOLID.SOLID.I.GOOD.HPLaserJetPrinter();
hPLaserJetPrinterGood.Print("print content");
hPLaserJetPrinterGood.Fax("fax content");
hPLaserJetPrinterGood.PrintDuplex("printduplex content");
hPLaserJetPrinterGood.Scan("scan content");

EXOSSOLID.SOLID.I.GOOD.LiquidInkjetPrinter liquidInkjetPrinter = new EXOSSOLID.SOLID.I.GOOD.LiquidInkjetPrinter();
liquidInkjetPrinter.Print("print content"); // OK ! Aucune autre méthode ne sera suggerée car les interfaces implémentées sont précisément celles dont a besoin l'objet !
/*
DIP Dependancy Injection Principle:
*/

//BAD: 


//GOOD: