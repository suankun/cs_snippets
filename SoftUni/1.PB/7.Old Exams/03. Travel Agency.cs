string city = Console.ReadLine();
string package = Console.ReadLine();
string vip = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

bool isCorrect = true;
double price = 0.0;
if (days < 1)
{
    Console.WriteLine("Days must be positive number!");
    isCorrect = false;
}
else if (city == "Bansko" || city == "Borovets")
{
    if (package == "withEquipment")
    {
        price = 100.0;
        if (vip == "yes") price *= 0.9;
    }
    else if (package == "noEquipment")
    {
        price = 80.0;
        if (vip == "yes") price *= 0.95;
    }
    else
    {
        Console.WriteLine("Invalid input!");
        isCorrect = false;
    }

}
else if (city == "Varna" || city == "Burgas")
{
    if (package == "withBreakfast")
    {
        price = 130.0;
        if (vip == "yes") price *= 0.88;
    }
    else if (package == "noBreakfast")
    {
        price = 100.0;
        if (vip == "yes") price *= 0.93;
    }
    else
    {
        Console.WriteLine("Invalid input!");
        isCorrect = false;
    }
}
else
{
    Console.WriteLine("Invalid input!");
    isCorrect = false;
}

if (days > 7) days--;
if (isCorrect) Console.WriteLine($"The price is {price * days:f2}lv! Have a nice time!");
