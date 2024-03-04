string name = Console.ReadLine();
string package = Console.ReadLine();
int ticketsNum = int.Parse(Console.ReadLine());

double price = 0.0;
if (name == "John Wick")
{
    if (package == "Drink") price = 12;
    else if (package == "Popcorn") price = 15;
    else price = 19;
}
else if (name == "Star Wars")
{
    if (package == "Drink") price = 18;
    else if (package == "Popcorn") price = 25;
    else price = 30;
    if (ticketsNum >= 4) price *= 0.7;
}
else
{
    if (package == "Drink") price = 9;
    else if (package == "Popcorn") price = 11;
    else price = 14;
    if (ticketsNum == 2) price *= 0.85;
}

Console.WriteLine($"Your bill is {price * ticketsNum:f2} leva.");
