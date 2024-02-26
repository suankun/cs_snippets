double trunkCap = double.Parse(Console.ReadLine());

int luggageNum = 0;
string command = Console.ReadLine();
while (command != "End")
{
    double currLuggage = double.Parse(command);
    luggageNum++;
    if (luggageNum % 3 == 0) trunkCap -= currLuggage * 1.1;
    else trunkCap -= currLuggage;

    if (trunkCap < 0)
    {
        luggageNum--;
        break;
    }

    command = Console.ReadLine();
}

if (command == "End") Console.WriteLine("Congratulations! All suitcases are loaded!");
else Console.WriteLine("No more space!");
Console.WriteLine($"Statistic: {luggageNum} suitcases loaded.");
