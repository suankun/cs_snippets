int windowsNum = int.Parse(Console.ReadLine());
string windowsType = Console.ReadLine();
string delivery = Console.ReadLine();

double price = 0.0;

bool isValid = true;

if (windowsNum < 10)
{
    Console.WriteLine("Invalid order");
    isValid = false;
}

if (windowsType == "90X130")
{
    price = 110.0;
    if (windowsNum > 60) price *= 0.92;
    else if (windowsNum > 30) price *= 0.95;
}
else if (windowsType == "100X150")
{
    price = 140.0;
    if (windowsNum > 80) price *= 0.90;
    else if (windowsNum > 40) price *= 0.94;
}
else if (windowsType == "130X180")
{
    price = 190.0;
    if (windowsNum > 50) price *= 0.88;
    else if (windowsNum > 20) price *= 0.93;
}
else if (windowsType == "200X300")
{
    price = 250.0;
    if (windowsNum > 50) price *= 0.86;
    else if (windowsNum > 25) price *= 0.91;
}

double totalPrice = price * windowsNum;

if (delivery == "With delivery") totalPrice += 60.0;

if (windowsNum > 99) totalPrice *= 0.96;

if (isValid) Console.WriteLine($"{totalPrice:F2} BGN");
