double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double price = 0.0;
if (season == "Winter")
{
    if (destination == "Dubai") price = 45000;
    else if (destination == "Sofia") price = 17000;
    else price = 24000;
}
else
{
    if (destination == "Dubai") price = 40000;
    else if (destination == "Sofia") price = 12500;
    else price = 20250;
}

double finalPrice = price * days;

if (destination == "Dubai") finalPrice *= 0.7;
else if (destination == "Sofia") finalPrice *= 1.25;

if (budget >= finalPrice) Console.WriteLine($"The budget for the movie is enough! We have {budget - finalPrice:f2} leva left!");
else Console.WriteLine($"The director needs {finalPrice - budget:f2} leva more!");
