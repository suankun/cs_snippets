double budget = double.Parse(Console.ReadLine());
char sex = char.Parse(Console.ReadLine());
int age = int.Parse(Console.ReadLine());
string sportType = Console.ReadLine();

double price = 0.0;

if (sex == 'm')
{
    if (sportType == "Gym") price = 42.00;
    else if (sportType == "Boxing") price = 41.00;
    else if (sportType == "Yoga") price = 45.00;
    else if (sportType == "Zumba") price = 34.00;
    else if (sportType == "Dances") price = 51.00;
    else if (sportType == "Pilates") price = 39.00;
}
else
{
    if (sportType == "Gym") price = 35.00;
    else if (sportType == "Boxing") price = 37.00;
    else if (sportType == "Yoga") price = 42.00;
    else if (sportType == "Zumba") price = 31.00;
    else if (sportType == "Dances") price = 53.00;
    else if (sportType == "Pilates") price = 37.00;
}

if (age <= 19) price *= 0.8;

if (budget >= price) Console.WriteLine($"You purchased a 1 month pass for {sportType}.");
else Console.WriteLine($"You don't have enough money! You need ${price - budget:F2} more.");
