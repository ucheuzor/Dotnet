
Random random = new Random();
int coinToss = random.Next(0, 2);

string outcome = coinToss > 0 ? "Head" : "Tail";

Console.WriteLine($"You tossed {outcome}");

/*
int salesAmount = 1001;

int discount = salesAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: ${discount}");
*/