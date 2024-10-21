//Toss a Coin for head or til. Outcome  for each should be 50%
using System.Security.Principal;

Random random = new Random();
int coinToss = random.Next(0, 2);

string outcome = coinToss > 0 ? "Head" : "Tail";

Console.WriteLine($"You tossed {outcome}");

//- - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//This code applies conditional logic to check a discount based on the  salesAmount

int salesAmount = 1001;

int discount = salesAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: ${discount}");


//- - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//This code is used to check user persmission based on the users level and permission

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


//- - - - - - - - - -  - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//This code is used to check if a number is within the array. Also sum the numbers. The concept of the exercise is to write the code concisely.

int[] numbers = [4, 8, 15, 16, 23, 42];

bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;

}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");