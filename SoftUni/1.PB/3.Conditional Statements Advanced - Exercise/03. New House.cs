string flower = Console.ReadLine();
int flowerNumber = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double total = 0.0;

if (flower == "Roses")
{
    total = flowerNumber * 5.0;
    if (flowerNumber > 80) total *= 0.9;
}
else if (flower == "Dahlias")
{
    total = flowerNumber * 3.8;
    if (flowerNumber > 90) total *= 0.85;
}
else if (flower == "Tulips")
{
    total = flowerNumber * 2.8;
    if (flowerNumber > 80) total *= 0.85;
}
else if (flower == "Narcissus")
{
    total = flowerNumber * 3.0;
    if (flowerNumber < 120) total *= 1.15;
}
else if (flower == "Gladiolus")
{
    total = flowerNumber * 2.5;
    if (flowerNumber < 80) total *= 1.2;
}

if (budget >= total)
    Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flower} and {budget - total:F2} leva left.");
else
    Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
