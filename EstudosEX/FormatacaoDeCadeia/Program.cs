/*string first = "hello";
string second = "world";    
string result = string.Format("{0} {1}!", first, second);
string result = string.Format("{1} {0}!", first, second);
string result = string.Format("{0} {0} {0}!");

Console.WriteLine(result);
//
decimal price = 29.99m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
//
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice number: {invoiceNumber} \nProduct shares: {productShares:N3} Product \nSubtotal: {subtotal:C} \nTax: {taxPercentage:P2} \nTotal billed: {total:C}");
//
 string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadRight(12));
 Console.WriteLine(input.PadLeft(12, '*').PadRight(16, '*'));
 //
 */

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine(formattedLine);


