int groupsNumber = int.Parse(Console.ReadLine());

int musalla = 0, montBlanc = 0, kilimanjaro = 0, K2 = 0, everest = 0;

for (int i = 0; i < groupsNumber; i++)
{
    int numberOfPeopleInTheGroup = int.Parse(Console.ReadLine());
    if (numberOfPeopleInTheGroup <= 5) musalla += numberOfPeopleInTheGroup;
    else if (numberOfPeopleInTheGroup >= 6 && numberOfPeopleInTheGroup <= 12) montBlanc += numberOfPeopleInTheGroup;
    else if (numberOfPeopleInTheGroup >= 13 && numberOfPeopleInTheGroup <= 25) kilimanjaro += numberOfPeopleInTheGroup;
    else if (numberOfPeopleInTheGroup >= 26 && numberOfPeopleInTheGroup <= 40) K2 += numberOfPeopleInTheGroup;
    else if (numberOfPeopleInTheGroup >= 41) everest += numberOfPeopleInTheGroup;
}

double total = musalla + montBlanc + kilimanjaro + K2 + everest;

Console.WriteLine($"{musalla / total * 100:F2}%");
Console.WriteLine($"{montBlanc / total * 100:F2}%");
Console.WriteLine($"{kilimanjaro / total * 100:F2}%");
Console.WriteLine($"{K2 / total * 100:F2}%");
Console.WriteLine($"{everest / total * 100:F2}%");
