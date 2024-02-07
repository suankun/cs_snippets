int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakePcs = width * length;

string command = Console.ReadLine();
while (command != "STOP")
{
    int currentPcsTaken = int.Parse(command);
    cakePcs -= currentPcsTaken;
    if (cakePcs <= 0) break;
    command = Console.ReadLine();
}

if (command == "STOP") Console.WriteLine($"{cakePcs} pieces are left.");
else  Console.WriteLine($"No more cake left! You need {Math.Abs(cakePcs)} pieces more.");