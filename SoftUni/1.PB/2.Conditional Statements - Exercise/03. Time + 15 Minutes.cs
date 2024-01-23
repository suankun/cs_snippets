int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int totalMinutes = hours * 60 + minutes + 15;

int newHours = totalMinutes / 60;
if (newHours >= 24) newHours -= 24;
int newMinutes = totalMinutes % 60;
if (newMinutes < 10)
{
    Console.WriteLine($"{newHours}:0{newMinutes}");
}
else
{
    Console.WriteLine($"{newHours}:{newMinutes}");
}
