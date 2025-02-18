﻿/*
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
Console.WriteLine("Bad proposed Invoice result with 200: " +invoiceBad2.GetInvoiceDiscount(200, EXOSSOLID.SOLID.O.BAD.InvoiceType.ProposedInvoice));

//GOOD:
EXOSSOLID.SOLID.O.GOOD.Invoice finalInvoice = new EXOSSOLID.SOLID.O.GOOD.FinalInvoice();
Console.WriteLine("Good final Invoice result with 150: " + finalInvoice.GetInvoiceDiscount(150));

EXOSSOLID.SOLID.O.GOOD.Invoice proposedInvoice = new EXOSSOLID.SOLID.O.GOOD.ProposedInvoice();
Console.WriteLine("Good proposed Invoice result with 200: " +proposedInvoice.GetInvoiceDiscount(200));

/*
LSP Liskov Substitution Principle:
*/

//BAD: 


//GOOD:

/*
ISP Interface Segregation Principle:
*/

//BAD: 


//GOOD:

/*
DIP Dependancy Injection Principle:
*/

//BAD: 


//GOOD: