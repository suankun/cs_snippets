int height = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int percent = int.Parse(Console.ReadLine());

double totalWallsForPaint = Math.Ceiling((height * width * 4) * (1.0 - percent / 100.0));
string command = Console.ReadLine();
while (command != "Tired!")
{
    int currentPaint = int.Parse(command);
    totalWallsForPaint -= currentPaint;
    if (totalWallsForPaint <= 0) break;
    command = Console.ReadLine();
}

if (command == "Tired!") Console.WriteLine($"{totalWallsForPaint} quadratic m left.");
else
{
    if (totalWallsForPaint < 0) Console.WriteLine($"All walls are painted and you have {Math.Abs(totalWallsForPaint)} l paint left!");
    else Console.WriteLine("All walls are painted! Great job, Pesho!");
}
