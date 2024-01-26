int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double total = 0.0;

if (season == "Spring") total = 3000.0;
else if (season == "Summer" || season == "Autumn") total = 4200.0;
else if (season == "Winter") total = 2600.0;

if (fishermen <= 6) total *= 0.9;
else if (fishermen >= 7 && fishermen <= 11) total *= 0.85;
else if (fishermen >= 12) total *= 0.75;

if (fishermen % 2 == 0 && season != "Autumn") total *= 0.95;

if (budget >= total)
    Console.WriteLine($"Yes! You have {budget - total:F2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {total - budget:F2} leva.");
