int walkMin = int.Parse(Console.ReadLine());
int walkNum = int.Parse(Console.ReadLine());
int caloriesIntake = int.Parse(Console.ReadLine());

int totalCalBurned = walkMin * 5 * walkNum;

if (totalCalBurned >= caloriesIntake / 2.0)
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalBurned}.");
else
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalBurned}.");
