string playersName = Console.ReadLine();

int points = 301, successfulShots = 0, unsuccessfulShots = 0;
string command = Console.ReadLine();
while (command != "Retire")
{
    int currentShot = int.Parse(Console.ReadLine());

    if (command == "Double")
    {
        currentShot *= 2;
    }
    else if (command == "Triple")
    {
        currentShot *= 3;
    }

    if (points - currentShot < 0)
    {
        unsuccessfulShots++;
    }
    else
    {
        successfulShots++;
        points -= currentShot;
    }

    if (points == 0)
    {
        break;
    }

    command = Console.ReadLine();
}

if (points == 0)
{
    Console.WriteLine($"{playersName} won the leg with {successfulShots} shots.");
}
else
{
    Console.WriteLine($"{playersName} retired after {unsuccessfulShots} unsuccessful shots.");
}
