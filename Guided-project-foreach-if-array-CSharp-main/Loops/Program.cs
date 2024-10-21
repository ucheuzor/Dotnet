﻿
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
Console.WriteLine("---------------------------");
Console.WriteLine("---------------------------\n");

//The Code below generates array of numbers from 1 - 100, then if a number is divisible by 3, Print Fizz, if divisible by 5, write Buzz, If divisible by 3 and 5, write FizzBuzz

int[] numbers = new int[100];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;

    if (numbers[i] % 5 == 0 && numbers[i] % 3 == 0)
        Console.WriteLine($"FizzBuzz - {numbers[i]}");
    else if (numbers[i] % 3 == 0)
        Console.WriteLine($"Fizz - {numbers[i]}");
    else if (numbers[i] % 5 == 0)
        Console.WriteLine($"Buzz - {numbers[i]}");
    else
        Console.WriteLine($"{numbers[i]}");

}