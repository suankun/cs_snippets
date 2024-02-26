int totalFood = int.Parse(Console.ReadLine()) * 1000;

string command = Console.ReadLine();
while (command != "Adopted")
{
    totalFood -= int.Parse(command);
    command = Console.ReadLine();
}

if (totalFood >= 0) Console.WriteLine($"Food is enough! Leftovers: {totalFood} grams.");
else Console.WriteLine($"Food is not enough. You need {totalFood * -1} grams more.");
