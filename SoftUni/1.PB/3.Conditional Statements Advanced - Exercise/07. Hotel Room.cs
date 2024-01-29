string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double apartment = 0.0;
double studio = 0.0;

if (month == "May" || month == "October")
{
    apartment = 65.0;
    studio = 50.0;
    if (nights > 14) studio *= 0.7;
    else if (nights > 7) studio *= 0.95;
    if (nights > 14) apartment *= 0.9;
}
else if (month == "June" || month == "September")
{
    apartment = 68.70;
    studio = 75.20;
    if (nights > 14) studio *= 0.8;
    if (nights > 14) apartment *= 0.9;
}
else if (month == "July" || month == "August")
{
    apartment = 77.0;
    studio = 76.0;
    if (nights > 14) apartment *= 0.9;
}

Console.WriteLine($"Apartment: {apartment * nights:F2} lv.");
Console.WriteLine($"Studio: {studio * nights:F2} lv.");
