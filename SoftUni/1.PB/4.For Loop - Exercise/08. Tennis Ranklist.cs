int tournamentsNumber = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int initPointsSave = initialPoints;
int wins = 0;

for (int i = 0; i < tournamentsNumber; i++)
{
    string tournamentStage = Console.ReadLine();
    if (tournamentStage == "W") initialPoints += 2000;
    else if (tournamentStage == "F") initialPoints += 1200;
    else if (tournamentStage == "SF") initialPoints += 720;
    if (tournamentStage == "W") wins++;
}

int avg = (initialPoints - initPointsSave) / tournamentsNumber;

Console.WriteLine($"Final points: {initialPoints}");
Console.WriteLine($"Average points: {avg}");
Console.WriteLine($"{wins * 1.0 / tournamentsNumber * 100.0:F2}%");
