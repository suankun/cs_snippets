int seatsNum = int.Parse(Console.ReadLine());

int money = 0;
string command = Console.ReadLine();
while (command != "Movie time!")
{
    int currPeople = int.Parse(command);
    if (seatsNum - currPeople < 0) break;
    else seatsNum -= currPeople;
    if (currPeople % 3 == 0) money += (currPeople * 5) - 5;
    else money += (currPeople * 5);
    command = Console.ReadLine();
}

if (command == "Movie time!") Console.WriteLine($"There are {seatsNum} seats left in the cinema.");
else Console.WriteLine("The cinema is full.");
Console.WriteLine($"Cinema income - {money} lv.");
