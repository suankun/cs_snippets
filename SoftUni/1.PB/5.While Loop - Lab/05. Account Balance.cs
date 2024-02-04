string command = Console.ReadLine();
double totalAmount = 0;

while (command != "NoMoreMoney")
{
    double tempNum = double.Parse(command);
    if (tempNum < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {tempNum:F2}");
    totalAmount += tempNum;
    command = Console.ReadLine();
}

Console.WriteLine($"Total: {totalAmount:F2}");
