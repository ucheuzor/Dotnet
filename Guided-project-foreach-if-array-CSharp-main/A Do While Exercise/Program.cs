
/*
This application is a simple game between a hero and a monster. Based on the strikes, we determine the health of the monster and the Hero. There is a winner if one of the player's health is less than or equal to zero
*/

int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();
int heroStrike = random.Next(1, 11);
int monsterStrike = 0;

while (heroHealth > 0 && monsterHealth > 0)
{
    monsterHealth -= heroStrike;

    //Check Monster health
    if (monsterHealth > 0)
    {
        Console.WriteLine($"Monster was damaged and lost {heroStrike} health and now has {monsterHealth} health.");
        monsterStrike = random.Next(1, 11);
        heroHealth -= monsterStrike;

    }
    else
    {
        Console.WriteLine($"Monster was damaged and lost {heroStrike} health and now has {monsterHealth} health.\n Hero Wins!");
        break;
    }

    //Check Hero health
    if (heroHealth > 0)
    {
        Console.WriteLine($"Hero  was damaged and lost {monsterStrike} health and now has {heroHealth} health.");
        heroStrike = random.Next(1, 11);
    }
    else
    {
        Console.WriteLine($"Hero was damaged and lost {monsterStrike} health and now has {heroHealth} health.\n Monster Wins!");
    }

}
