
void DisplayRandomNumber()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int nextNumber = random.Next(1, 100);

        Console.Write($"{nextNumber} ");
    }
    Console.WriteLine();
};

Console.WriteLine("Generating random numbers:");
DisplayRandomNumber();



/*

int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("Contents of Array:");
Console.WriteLine("Before calling a method");
PrintArray();
Console.WriteLine("After calling a method");

void PrintArray()
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");

    }
    Console.WriteLine();
}
*/