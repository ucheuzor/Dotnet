
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

string[] names = ["Uchenna Uzor", "Favour James", "Roland Robbins"];
int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;

foreach (string name in names)
{
    Console.WriteLine(name);
};
Console.WriteLine("\n");

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory");

/*
Console.WriteLine(fraudulentOrderIDs[2]);
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/