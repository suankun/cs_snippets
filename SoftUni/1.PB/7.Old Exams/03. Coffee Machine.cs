string beverage = Console.ReadLine();
string sugar = Console.ReadLine();
int beverageNum = int.Parse(Console.ReadLine());

double price = 0.0;
if (beverage == "Espresso")
{
    if (sugar == "Without") price = 0.90 * 0.65;
    else if (sugar == "Normal") price = 1.00;
    else if (sugar == "Extra") price = 1.20;
    if (beverageNum >= 5) price *= 0.75;
}
else if (beverage == "Cappuccino")
{
    if (sugar == "Without") price = 1.00 * 0.65;
    else if (sugar == "Normal") price = 1.20;
    else if (sugar == "Extra") price = 1.60;
}
else if (beverage == "Tea")
{
    if (sugar == "Without") price = 0.50 * 0.65;
    else if (sugar == "Normal") price = 0.60;
    else if (sugar == "Extra") price = 0.70;
}

double totalPrice = price * beverageNum;
if (totalPrice > 15.0) totalPrice *= 0.8;

Console.WriteLine($"You bought {beverageNum} cups of {beverage} for {totalPrice:f2} lv.");
