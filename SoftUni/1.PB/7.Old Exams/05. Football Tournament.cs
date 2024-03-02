string name = Console.ReadLine();
int matches = int.Parse(Console.ReadLine());

int win = 0, draw = 0, lose = 0, totalPoints = 0;
for (int i = 0; i < matches; i++)
{
    char currMatch = char.Parse(Console.ReadLine());
    if (currMatch == 'W')
    {
        totalPoints += 3;
        win++;
    }
    else if (currMatch == 'D')
    {
        totalPoints += 1;
        draw++;
    }
    else
    {
        lose++;
    }
}

if (matches == 0)
{
    Console.WriteLine($"{name} hasn't played any games during this season.");
}
else
{
    Console.WriteLine($"{name} has won {totalPoints} points during this season.");
    Console.WriteLine($"Total stats:");
    Console.WriteLine($"## W: {win}");
    Console.WriteLine($"## D: {draw}");
    Console.WriteLine($"## L: {lose}");
    Console.WriteLine($"Win rate: {(double)win / matches * 100.0:f2}%");
}
