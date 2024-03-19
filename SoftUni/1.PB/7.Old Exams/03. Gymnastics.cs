string country = Console.ReadLine();
string discipline = Console.ReadLine();

double totalPoints = 0.0;
if (country == "Russia")
{
    if (discipline == "ribbon") totalPoints = 9.1 + 9.4;
    else if (discipline == "hoop") totalPoints = 9.3 + 9.8;
    else if (discipline == "rope") totalPoints = 9.6 + 9.0;
}
else if (country == "Bulgaria")
{
    if (discipline == "ribbon") totalPoints = 9.6 + 9.4;
    else if (discipline == "hoop") totalPoints = 9.55 + 9.75;
    else if (discipline == "rope") totalPoints = 9.5 + 9.4;
}
else if (country == "Italy")
{
    if (discipline == "ribbon") totalPoints = 9.2 + 9.5;
    else if (discipline == "hoop") totalPoints = 9.45 + 9.35;
    else if (discipline == "rope") totalPoints = 9.7 + 9.15;
}

Console.WriteLine($"The team of {country} get {totalPoints:f3} on {discipline}.");
Console.WriteLine($"{(20 - totalPoints) / 20.0 * 100.0:f2}%");
