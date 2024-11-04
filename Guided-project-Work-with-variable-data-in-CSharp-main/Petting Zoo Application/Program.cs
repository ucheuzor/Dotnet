
string[] pettingZoo =
[
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
];

RandomizeAnimals();

string[,] group = AssignGroup();

Console.WriteLine("School A");

foreach (string animal in pettingZoo)
{
    Console.WriteLine(animal);
}

// PrintGroup(group);

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
};

//groups parameter define the number of groups we want to create. pettingZoo.Length / groups defines the number of animals to add to each groups.
string[,] AssignGroup(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];

    return result;
}
