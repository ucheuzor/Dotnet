//A simple C# application that gets all the numbers from an array and add them together. Then Concatenate all the Strings together

string[] values = ["12.3", "45", "ABC", "11", "DEF"];
float total = 0f;

string message = String.Empty;

for (int i = 0; i < values.Length; i++)
{
    float currentItem;
    if (float.TryParse(values[i], out currentItem))
        total += currentItem;
    else
        message = $"{message}{values[i]}";

}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");




/* 
 int value = (int)1.9m;
int value2 = Convert.ToInt32(1.4m);


Console.WriteLine(value);
Console.WriteLine(value2); 

string value = "1000";
int result = 0;

if (int.TryParse(value, out result))
    Console.WriteLine($"Measurement: {result}");
else
    Console.WriteLine("Unable to report the measurement");

Console.WriteLine($"Measurement (w/ offset): {50 + result}"); */
