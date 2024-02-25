string fruit = Console.ReadLine();
string size = Console.ReadLine();
int sets = int.Parse(Console.ReadLine());

double price = 0.0;
if (size == "small")
{
    if (fruit == "Watermelon") price = 56.00;
    else if (fruit == "Mango") price = 36.66;
    else if (fruit == "Pineapple") price = 42.10;
    else if (fruit == "Raspberry") price = 20.00;
    price *= 2.0 * sets;
}
else if (size == "big")
{
    if (fruit == "Watermelon") price = 28.70;
    else if (fruit == "Mango") price = 19.60;
    else if (fruit == "Pineapple") price = 24.80;
    else if (fruit == "Raspberry") price = 15.20;
    price *= 5.0 * sets;
}

if (price > 1000) price *= 0.5;
else if (price >= 400) price *= 0.85;

Console.WriteLine($"{price:F2} lv.");
