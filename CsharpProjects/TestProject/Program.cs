

internal class Program
{
    private static void Main(string[] args)
    {
        Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


        if (total >= 15)
        {
            Console.WriteLine($"You win because total is {total}");
        }
        else
        {
            Console.WriteLine($"Sorry, you lost because total is {total}");
        }
        //check for doubles roll match
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            //Check for exact matches

            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
                Console.WriteLine($"The new total for tripple match is {total}");
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
                Console.WriteLine($"The new total for double match is {total}");
            }

        }


    }
}


