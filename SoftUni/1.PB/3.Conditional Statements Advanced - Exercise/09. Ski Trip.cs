int days = int.Parse(Console.ReadLine());
string type  = Console.ReadLine();
string review = Console.ReadLine();

double total = 0.0;

if (type == "room for one person")
{
    total = (days - 1) * 18.00;
}
else if (type == "apartment")
{
    total = (days - 1) * 25.00;
    if (days < 10) total *= 0.7;
    else if (days >= 10 && days <= 15) total *= 0.65;
    else total *= 0.5;
}
else if (type == "president apartment")
{
    total = (days - 1) * 35.00;
    if (days < 10) total *= 0.9;
    else if (days >= 10 && days <= 15) total *= 0.85;
    else total *= 0.8;
}

if (review == "positive") total += total * 0.25;
else total -= total * 0.1;

Console.WriteLine($"{total:F2}");
