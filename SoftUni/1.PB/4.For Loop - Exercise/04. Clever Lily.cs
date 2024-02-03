int age = int.Parse(Console.ReadLine());
double priceOfWasher = double.Parse(Console.ReadLine());
int priceOfToy = int.Parse(Console.ReadLine());

double money = 0.0;
int toysCnt = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        money += (10 * (i / 2)) - 1;
    }
    else
    {
        toysCnt++;
    }
}

money += toysCnt * priceOfToy;

if (money >= priceOfWasher) Console.WriteLine($"Yes! {money - priceOfWasher:F2}");
else Console.WriteLine($"No! {priceOfWasher - money:F2}");
