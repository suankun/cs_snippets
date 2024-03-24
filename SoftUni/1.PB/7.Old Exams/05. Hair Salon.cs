int dailyTarget = int.Parse(Console.ReadLine());

int moneyEarn = 0;
string command = Console.ReadLine();
while (command != "closed")
{
    if (command == "haircut")
    {
        string type = Console.ReadLine();
        if (type == "mens") moneyEarn += 15;
        else if (type == "ladies") moneyEarn += 20;
        else if (type == "kids") moneyEarn += 10;
    }
    else if (command == "color")
    {
        string type = Console.ReadLine();
        if (type == "touch up") moneyEarn += 20;
        else if (type == "full color") moneyEarn += 30;
    }

    if (moneyEarn >= dailyTarget)
    {
        break;
    }

    command = Console.ReadLine();
}

if (moneyEarn >= dailyTarget)
{
    Console.WriteLine("You have reached your target for the day!");
}
else
{
    Console.WriteLine($"Target not reached! You need {dailyTarget - moneyEarn}lv. more.");
}

Console.WriteLine($"Earned money: {moneyEarn}lv.");
