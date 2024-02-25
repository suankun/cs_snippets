int days = int.Parse(Console.ReadLine());
double totalFood = double.Parse(Console.ReadLine());

int cat = 0, dog = 0;
double cookies = 0.0;
for (int i = 1; i <= days; i++)
{
    int currDog = int.Parse(Console.ReadLine());
    int currCat = int.Parse(Console.ReadLine());
    totalFood -= currDog + currCat;
    dog += currDog;
    cat += currCat;
    if (i % 3 == 0) cookies += (currDog+currCat) * 0.1;
}

double eatenFood = dog + cat;
Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
Console.WriteLine($"{eatenFood / (eatenFood + totalFood) * 100.0:F2}% of the food has been eaten.");
Console.WriteLine($"{dog / eatenFood * 100:F2}% eaten from the dog.");
Console.WriteLine($"{cat / eatenFood * 100:F2}% eaten from the cat.");
