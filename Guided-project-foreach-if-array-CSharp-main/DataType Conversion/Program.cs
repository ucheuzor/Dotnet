
/* int value = (int)1.9m;
int value2 = Convert.ToInt32(1.4m);


Console.WriteLine(value);
Console.WriteLine(value2); */

string value = "1000";
int result = 0;

if (int.TryParse(value, out result))
    Console.WriteLine($"Measurement: {result}");
else
    Console.WriteLine("Unable to report the measurement");

Console.WriteLine($"Measurement (w/ offset): {50 + result}");
