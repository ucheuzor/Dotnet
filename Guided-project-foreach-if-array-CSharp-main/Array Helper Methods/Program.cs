
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");

Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"...{pallet}");
}



Array.Clear(pallets, 1, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"...{pallet}");
}
