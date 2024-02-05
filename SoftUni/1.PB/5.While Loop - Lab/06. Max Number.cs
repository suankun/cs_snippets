string command = Console.ReadLine();
int maxNum = int.MinValue;

while (command != "Stop")
{
    int tempNum = int.Parse(command);
    if (maxNum < tempNum) maxNum = tempNum;
    command = Console.ReadLine();
}

Console.WriteLine($"{maxNum}");
