string command = Console.ReadLine();

string bestPlayer = "";
int bestScore = 0;

while (command != "END")
{
    int currGoals = int.Parse(Console.ReadLine());
    if (bestScore < currGoals)
    {
        bestScore = currGoals;
        bestPlayer = command;
    }
    if (currGoals >= 10) break;
    command = Console.ReadLine();
}

Console.WriteLine($"{bestPlayer} is the best player!");
if (bestScore < 3) Console.WriteLine($"He has scored {bestScore} goals.");
else Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
