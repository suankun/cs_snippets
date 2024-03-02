string bestName = "";
int bestPt = 0;
string command = Console.ReadLine();
while (command != "Stop")
{
    int points = 0;
    for (int i = 0; i < command.Length; i++)
    {
        int asciiValue = command[i];
        int num = int.Parse(Console.ReadLine());
        if (asciiValue == num) points += 10;
        else points += 2;
    }
    if (bestPt <= points)
    {
        bestName = command;
        bestPt = points;
    }
    command = Console.ReadLine();
}

Console.WriteLine($"The winner is {bestName} with {bestPt} points!");
