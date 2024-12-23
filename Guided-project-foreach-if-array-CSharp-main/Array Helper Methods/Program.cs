﻿string value = "abcd1234";

char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);

string result = new string(valueArray);

Console.WriteLine($"result: {result}");
Console.WriteLine($"CharArray: {valueArray}");
Console.WriteLine("");

foreach (char arg in valueArray)
{
    Console.WriteLine(arg);
}




string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");

Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"...{pallet}");
}



Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"...{pallet}");
}

//Resizing the array

Console.WriteLine("");
Array.Resize(ref pallets, 6);

Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}