
//C# Program that converts US Dollars to Vietnamese Dollars
double usd = 23.73;
int vndDefault = 150000;
int vnd = UsdToVnD(usd);
double vndToUsd = VndToUsd(vndDefault);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vndDefault} VND = ${vndToUsd.ToString().Substring(0, 4)} USD");

int UsdToVnD(double usd)
{
    int rate = 23500;

    return (int)(rate * usd);
}

//C# Program that converts Vietnamese Dollars to US Dollars
double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

/*
double total = 0;
double minimumSpend = 30.00;

double[] items = [15.97, 3.50, 12.25, 22.99, 10.98];
double[] discounts = [0.30, 0.00, 0.10, 0.20, 0.50];

for (int i = 0; i < items.Length; i++)
{

    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{

    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
*/