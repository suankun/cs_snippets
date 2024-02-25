int groups = int.Parse(Console.ReadLine());

int musala = 0, montBlanc = 0, kilimanjaro = 0, K2 = 0, everest = 0;
for (int i = 0; i < groups; i++)
{
    int currGroup = int.Parse(Console.ReadLine());
    if (currGroup <= 5) musala += currGroup;
    else if (currGroup >= 6 && currGroup <= 12) montBlanc += currGroup;
    else if (currGroup >= 13 && currGroup <= 25) kilimanjaro += currGroup;
    else if (currGroup >= 26 && currGroup <= 40) K2 += currGroup;
    else if (currGroup >= 41) everest += currGroup;
}

double total = musala + montBlanc + kilimanjaro + K2 + everest;
Console.WriteLine($"{musala / total * 100.0:F2}%");
Console.WriteLine($"{montBlanc / total * 100.0:F2}%");
Console.WriteLine($"{kilimanjaro / total * 100.0:F2}%");
Console.WriteLine($"{K2 / total * 100.0:F2}%");
Console.WriteLine($"{everest / total * 100.0:F2}%");
