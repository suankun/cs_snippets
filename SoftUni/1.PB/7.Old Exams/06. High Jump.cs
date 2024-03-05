int goal = 0, wood = 0, jumpCount = 0, jump = 0;
goal = int.Parse(Console.ReadLine());
wood = goal - 30;

while ((wood - 5) < goal)
{
    int unsuccessful = 0;
    while (unsuccessful < 3)
    {
        jumpCount++;
        jump = int.Parse(Console.ReadLine());
        if (jump > wood) break;
        unsuccessful++;
    }
    if (unsuccessful == 3) break;
    wood += 5;
}

if (wood <= goal) Console.WriteLine($"Tihomir failed at {wood}cm after {jumpCount} jumps.");
else Console.WriteLine($"Tihomir succeeded, he jumped over {goal}cm after {jumpCount} jumps.");
