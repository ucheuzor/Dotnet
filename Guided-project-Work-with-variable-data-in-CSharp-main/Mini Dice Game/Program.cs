
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);

        WinOrLose(roll, target);

        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

void WinOrLose(int roll, int target)
{
    string response = "";
    bool outcomeCheck = false;

    Console.WriteLine($"Roll a number greater than {target} to win! your roll must between 1 - 6");

    do
    {
        response = Console.ReadLine();

        if (int.TryParse(response, out int outcome))
        {
            if (outcome < 1 || outcome > 6)
            {
                Console.WriteLine("entered value must between 1 - 6");
            }
            else
            {
                Console.WriteLine($"You rolled a {roll}");
                if (roll > target)
                {
                    Console.WriteLine("You win!");
                    outcomeCheck = true;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    outcomeCheck = true;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid response! enter a numeric value");
        }

    } while (outcomeCheck == false);

}

//

bool ShouldPlay()
{
    string? userResponse = Console.ReadLine();

    return userResponse?.Trim().ToLower() == "y" ? true : false;
}