//C# application to print the index of items where the sum of 2 items within the array matches the target point
int target = 60;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[,] outcome = TwoCoins(coins, target);

if (outcome.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions:");

    for (int i = 0; i < outcome.Length; i++)
    {
        if (outcome[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{outcome[i, 0]},{outcome[i, 1]}");
    }
}


int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {

        for (int next = curr + 1; next < coins.Length; next++)
        {
            int sumOfSuccessiveCoins = coins[curr] + coins[next];

            if (sumOfSuccessiveCoins == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;

            }

            if (count == result.GetLength(0))
            {
                return result;
            }

        }
    }
    return (count == 0) ? new int[0, 0] : result;
}

/*

//C# code to check if words within an array is a pallindrome
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    char[] splitedWord = word.Trim().ToCharArray();
    string reversedString = "";

    for (int i = splitedWord.Length - 1; i >= 0; i--)
    {
        reversedString += splitedWord[i];
    }

    if (reversedString == word)
        return true;

    return false;
}


// C# code to reverse a sentence
string name = "there are snakes at the zoo";
string reversedWord = ReverseWord(name);

Console.WriteLine($"The Reverse of {name} is {reversedWord}");


string ReverseWord(string word)
{
    char[] splitWord = word.ToCharArray();
    string result = "";

    for (int i = splitWord.Length - 1; i >= 0; i--)
    {
        result += splitWord[i].ToString();
    }

    return result;
}

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
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
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