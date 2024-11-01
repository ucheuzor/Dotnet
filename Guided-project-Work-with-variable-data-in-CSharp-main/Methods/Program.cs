
using CheckValidIP;

string ipv4Input = "107.31.1.5";
bool response = CheckIP.CalculateNumbers(ipv4Input);

if (response)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
/*

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());


if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();


void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
    Console.WriteLine();
}

void AdjustTimes()
{
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

*/
/*

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