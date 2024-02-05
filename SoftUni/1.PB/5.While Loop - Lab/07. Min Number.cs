string command = Console.ReadLine();
int minNum = int.MaxValue;

while (command != "Stop")
{
    int tempNum = int.Parse(command);
    if (minNum > tempNum) minNum = tempNum;
    command = Console.ReadLine();
}

Console.WriteLine($"{minNum}");
