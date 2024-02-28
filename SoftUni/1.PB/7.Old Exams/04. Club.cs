double target = double.Parse(Console.ReadLine());

double currentMoney = 0.0;
string command = Console.ReadLine();
while (command != "Party!")
{
    int cocktailNumber = int.Parse(Console.ReadLine());
    double currentOrder = cocktailNumber * command.Length;
    if (currentOrder % 2 != 0) currentOrder *= 0.75;
    currentMoney += currentOrder;
    if (currentMoney >= target) break;
    command = Console.ReadLine();
}

if (command == "Party!") Console.WriteLine($"We need {target - currentMoney:f2} leva more.");
else Console.WriteLine("Target acquired.");
Console.WriteLine($"Club income - {currentMoney:f2} leva.");
