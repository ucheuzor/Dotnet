//Toss a Coin for head or til. Outcome  for each should be 50%
Random random = new Random();
int coinToss = random.Next(0, 2);

string outcome = coinToss > 0 ? "Head" : "Tail";

Console.WriteLine($"You tossed {outcome}");

//- - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

string permission = "Admin|Manager";
int level = 10;

if (permission.Contains("Admin") && level > 55)
    Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Admin") && level <= 55)
    Console.WriteLine("Welcome, Admin user.");
else if (permission.Contains("Manager") && level >= 20)
    Console.WriteLine("Contact an Admin for access.");
else if (permission.Contains("Manager") && level < 20 || !permission.Contains("Admin") || !permission.Contains("Manager"))
    Console.WriteLine("You do not have sufficient privileges.");


/*
int salesAmount = 1001;

int discount = salesAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: ${discount}");
*/