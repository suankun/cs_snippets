int days = int.Parse(Console.ReadLine());

double totalMoney = 0.0;
int daysWin = 0, daysLose = 0;
for (int i = 0; i < days; i++)
{
    double currMoney = 0.0;
    int tournamentWin = 0, tournamentLose = 0;
    string command = Console.ReadLine();
    while (command != "Finish")
    {
        string result = Console.ReadLine();
        if (result == "win")
        {
            tournamentWin++;
            currMoney += 20.0;
        }
        else
        {
            tournamentLose++;
        }
        command = Console.ReadLine();
    }
    if (tournamentWin > tournamentLose)
    {
        currMoney *= 1.1;
        daysWin++;
    }
    else
    {
        daysLose++;
    }
    totalMoney += currMoney;
}

if (daysWin > daysLose)
{
    totalMoney *= 1.2;
    Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
}
else
{
    Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
}
