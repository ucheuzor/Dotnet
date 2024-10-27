
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3}");
Console.WriteLine($"Sub total: {subtotal:C}");
Console.WriteLine($"Tax: {taxPercentage:P2}");
Console.WriteLine($"Total: {total:C}");

//Add Padding 
Console.WriteLine("");
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '0'));


/* 
string firstName = "Uchenna";
string lastName = "Uzor";

string result = string.Format("{0} {1}", firstName, lastName);

Console.WriteLine(result);

//Formatting Currency

decimal price = 123.4m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Measurement
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");


//formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

//Calculating discount

decimal Itemprice = 67.55m;
decimal salePrice = 59.99m;

decimal discountPrice = Itemprice - salePrice;
Console.WriteLine($"A discount of {discountPrice / Itemprice:P2} was applied");
 */