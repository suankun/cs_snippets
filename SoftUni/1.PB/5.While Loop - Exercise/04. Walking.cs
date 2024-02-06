int goal = 10000;
int steps = 0;

string command = Console.ReadLine();
int currentSteps = 0;
while (command != "Going home")
{
    currentSteps = int.Parse(command);
    steps += currentSteps;
    if (steps >= goal) break;
    command = Console.ReadLine();
}

if (command == "Going home")
{
    currentSteps = int.Parse(Console.ReadLine());
    steps += currentSteps;
}

if (steps >= goal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{steps - goal} steps over the goal!");
}
else
{
    Console.WriteLine($"{goal - steps} more steps to reach goal.");
}
