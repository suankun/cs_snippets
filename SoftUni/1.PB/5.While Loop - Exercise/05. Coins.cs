decimal change = decimal.Parse(Console.ReadLine());
decimal leftChange = change;
int coins = 0;
while (leftChange > 0)
{
    if (leftChange >= 2) leftChange -= 2;
    else if (leftChange >= 1) leftChange -= 1;
    else if (leftChange >= 0.5m) leftChange -= 0.5m;
    else if (leftChange >= 0.2m) leftChange -= 0.2m;
    else if (leftChange >= 0.1m) leftChange -= 0.1m;
    else if (leftChange >= 0.05m) leftChange -= 0.05m;
    else if (leftChange >= 0.02m) leftChange -= 0.02m;
    else if (leftChange >= 0.01m) leftChange -= 0.01m;
    coins++;
}

Console.WriteLine(coins);
