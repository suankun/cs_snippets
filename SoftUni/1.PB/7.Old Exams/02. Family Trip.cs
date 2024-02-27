double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double pricePerNight = double.Parse(Console.ReadLine());
int percentAdditionalCost = int.Parse(Console.ReadLine());

double totalCost = 0.0;

if (nights > 7) pricePerNight *= 0.95;

totalCost = (pricePerNight * nights) + (percentAdditionalCost / 100.0 * budget);

if (budget >= totalCost) Console.WriteLine($"Ivanovi will be left with {budget - totalCost:f2} leva after vacation.");
else Console.WriteLine($"{totalCost - budget:f2} leva needed.");
