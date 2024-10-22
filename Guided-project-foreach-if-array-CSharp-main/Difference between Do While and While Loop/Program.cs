
//This C# code using a do while loop to check a user input. Only values between 5 - 10 are allowed. If user input is outside range, prompt the user to enter input

int userInput = 0;

Console.WriteLine("Enter a number between 5 - 10: ");
do
{
    string? userResponse = Console.ReadLine();

    if (int.TryParse(userResponse, out userInput))
    {
        if (userInput < 5 || userInput > 10)
            Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10");
        else
        {
            Console.WriteLine($"Input accepted: your inputted value is {userInput}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Your input is invalid. Please enter a valid integer");
    }


} while (userInput < 5 || userInput > 10);


/*
string? readResult;
bool validEntry = false;

Console.Write("Enter Your FullName: ");
do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
            Console.WriteLine($"Welcome, {readResult}");
        }
        else
        {
            Console.WriteLine("Your input is invalid, your entry must be greater than 3.");
        }
    }

} while (validEntry == false);
*/