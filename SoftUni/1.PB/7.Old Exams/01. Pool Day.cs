int peopleNum = int.Parse(Console.ReadLine());
double entranceFee = double.Parse(Console.ReadLine());
double sunbedFee = double.Parse(Console.ReadLine());
double umbrellaFee = double.Parse(Console.ReadLine());

double result = (peopleNum * entranceFee) + (Math.Ceiling(peopleNum / 2.0) * umbrellaFee) + (Math.Ceiling(peopleNum * 0.75) * sunbedFee);

Console.WriteLine($"{result:f2} lv.");
