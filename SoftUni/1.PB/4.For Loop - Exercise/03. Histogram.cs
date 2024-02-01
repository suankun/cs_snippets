int n = int.Parse(Console.ReadLine());

int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

for (int i=0; i<n; i++)
{
    int tempNum = int.Parse(Console.ReadLine());
    if (tempNum < 200) p1++;
    else if (tempNum >= 200 && tempNum < 400) p2++;
    else if (tempNum >= 400 && tempNum < 600) p3++;
    else if (tempNum >= 600 && tempNum < 800) p4++;
    else if (tempNum >= 800) p5++;
}

Console.WriteLine($"{(p1 * 1.0 / n) * 100:F2}%");
Console.WriteLine($"{(p2 * 1.0 / n) * 100:F2}%");
Console.WriteLine($"{(p3 * 1.0 / n) * 100:F2}%");
Console.WriteLine($"{(p4 * 1.0 / n) * 100:F2}%");
Console.WriteLine($"{(p5 * 1.0 / n) * 100:F2}%");
