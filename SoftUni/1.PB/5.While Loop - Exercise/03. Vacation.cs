double tripCost = double.Parse(Console.ReadLine());
double money = double.Parse(Console.ReadLine());

int days = 0;
int spendingDays = 0;
while (money < tripCost && spendingDays < 5)
{
    string command = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    if (command == "save")
    {
        money += amount;
        spendingDays = 0;
    }
    else
    {
        money -= amount;
        if (money < 0) money = 0;
        spendingDays++;
    }
    days++;
}

if (spendingDays == 5)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}
else
{
    Console.WriteLine($"You saved the money for {days} days.");
}
