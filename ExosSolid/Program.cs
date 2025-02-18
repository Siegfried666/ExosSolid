/*
SRP Single Responsability Principle
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
