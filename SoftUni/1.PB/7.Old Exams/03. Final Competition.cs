int dancers = int.Parse(Console.ReadLine());
double points = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string place = Console.ReadLine();

double totalMoney = 0.0;

if (place == "Bulgaria")
{
    totalMoney = points * dancers;
    if (season == "summer") totalMoney *= 0.95;
    else if (season == "winter") totalMoney *= 0.92;
}
else if (place == "Abroad")
{
    totalMoney = (dancers * points) * 1.5;
    if (season == "summer") totalMoney *= 0.90;
    else if (season == "winter") totalMoney *= 0.85;
}

double charity = totalMoney * 0.75;
totalMoney *= 0.25;

Console.WriteLine($"Charity - {charity:f2}");
Console.WriteLine($"Money per dancer - {totalMoney / dancers:f2}");
