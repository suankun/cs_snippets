string command = Console.ReadLine();
double budget = 0.0;

while (command != "End")
{
    budget = double.Parse(Console.ReadLine());
    while (budget > 0)
    {
        double currentAmount = double.Parse(Console.ReadLine());
        budget -= currentAmount;
    }
    Console.WriteLine($"Going to {command}!");
    command = Console.ReadLine();
}
