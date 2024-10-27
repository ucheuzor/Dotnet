string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}, \nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n\nHere's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);


// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

// Your logic here

Console.WriteLine(comparisonMessage);


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
