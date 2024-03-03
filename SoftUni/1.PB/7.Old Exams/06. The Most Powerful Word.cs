string word = "";
double points = 0.0;

string command = Console.ReadLine();

while (command != "End of words")
{
    double sum = 0;
    for (int i = 0; i < command.Length; i++) sum += command[i];
    if (command[0] == 'A' || command[0] == 'a' ||
        command[0] == 'E' || command[0] == 'e' ||
        command[0] == 'I' || command[0] == 'i' ||
        command[0] == 'O' || command[0] == 'o' ||
        command[0] == 'U' || command[0] == 'u' ||
        command[0] == 'Y' || command[0] == 'y') sum *= command.Length;
    else sum = Math.Floor(sum / command.Length);
    if (points < sum)
    {
        word = command;
        points = sum;
    }
    command = Console.ReadLine();
}

Console.WriteLine($"The most powerful word is {word} - {points}");
