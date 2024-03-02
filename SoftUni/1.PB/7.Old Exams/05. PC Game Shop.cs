int gamesSold = int.Parse(Console.ReadLine());

int hearthstone = 0, fornite = 0, overwatch = 0, others = 0;
for (int i = 0; i < gamesSold; i++)
{
    string name = Console.ReadLine();
    if (name == "Hearthstone") hearthstone++;
    else if (name == "Fornite") fornite++;
    else if (name == "Overwatch") overwatch++;
    else others++;
}

Console.WriteLine($"Hearthstone - {(double)hearthstone / gamesSold * 100.0:f2}%");
Console.WriteLine($"Fornite - {(double)fornite / gamesSold * 100.0:f2}%");
Console.WriteLine($"Overwatch - {(double)overwatch / gamesSold * 100.0:f2}%");
Console.WriteLine($"Others - {(double)others / gamesSold * 100.0:f2}%");
