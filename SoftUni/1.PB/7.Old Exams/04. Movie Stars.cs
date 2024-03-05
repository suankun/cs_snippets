double budget = double.Parse(Console.ReadLine());

string command = Console.ReadLine();
while (command != "ACTION")
{
    int len = command.Length;
    if (len > 15)
    {
        budget -= (budget * 0.2);
    }
    else
    {
        double salary = double.Parse(Console.ReadLine());
        budget -= salary;
    }
    if (budget < 0) break;
    command = Console.ReadLine();
}

if (budget < 0) Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
else Console.WriteLine($"We are left with {budget:f2} leva.");