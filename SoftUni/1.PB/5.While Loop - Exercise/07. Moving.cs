int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int space = width * length * height;

string command = Console.ReadLine();
while (command != "Done")
{
    int currentBoxes = int.Parse(command);
    space -= currentBoxes;
    if (space <= 0) break;
    command = Console.ReadLine();
}

if (command == "Done") Console.WriteLine($"{space} Cubic meters left.");
else  Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
