﻿
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);


void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;

    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (currentGMT <= 0 && newGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * Math.Abs(newGMT) - Math.Abs(currentGMT);
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

/*
Random random = new Random();
int luck = random.Next(100);

string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
*/


