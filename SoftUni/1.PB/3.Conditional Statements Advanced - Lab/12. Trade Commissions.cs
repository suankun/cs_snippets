string city = Console.ReadLine();
double sells = double.Parse(Console.ReadLine());

double commission = 0.0;
bool isCorrect = true;

if (city == "Sofia")
{
    if (sells >= 0 && sells <= 500) commission = 5 / 100.0;
    else if (sells > 500 && sells <= 1000) commission = 7 / 100.0;
    else if (sells > 1000 && sells <= 10000) commission = 8 / 100.0;
    else if (sells > 10000) commission = 12 / 100.0;
    else
    {
        isCorrect = false;
        Console.WriteLine("error");
    }
}
else if (city == "Varna")
{
    if (sells >= 0 && sells <= 500) commission = 4.5 / 100.0;
    else if (sells > 500 && sells <= 1000) commission = 7.5 / 100.0;
    else if (sells > 1000 && sells <= 10000) commission = 10 / 100.0;
    else if (sells > 10000) commission = 13 / 100.0;
    else
    {
        isCorrect = false;
        Console.WriteLine("error");
    }
}
else if (city == "Plovdiv")
{
    if (sells >= 0 && sells <= 500) commission = 5.5 / 100.0;
    else if (sells > 500 && sells <= 1000) commission = 8 / 100.0;
    else if (sells > 1000 && sells <= 10000) commission = 12 / 100.0;
    else if (sells > 10000) commission = 14.5 / 100.0;
    else
    {
        isCorrect = false;
        Console.WriteLine("error");
    }
}
else
{
    isCorrect = false;
    Console.WriteLine("error");
}

if (isCorrect) Console.WriteLine($"{sells * commission:F2}");
