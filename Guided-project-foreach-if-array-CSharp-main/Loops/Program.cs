
//for look to loop through an array using for loop.
string[] names = ["Uchenna", "david", "Eddie", "Samson"];

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);

}
Console.WriteLine("---------------------------");

for (int i = names.Length - 1; i >= 0; i--)
{
    if (names[i] == "Uchenna")
        names[i] = "Uchenna Uzor";


    Console.WriteLine(names[i]);
}

/*
for (int i = 1; i < 20; i += 3)
{

    if (i > 15)
        break;

    Console.WriteLine(i);
}
*/