double priceOver20kg = double.Parse(Console.ReadLine());
double luggageKg = double.Parse(Console.ReadLine());
int daysToTrip = int.Parse(Console.ReadLine());
int luggageNum = int.Parse(Console.ReadLine());

double totalPrice = 0.0;

if (luggageKg < 10) totalPrice = priceOver20kg * 0.2;
else if (luggageKg >= 10 && luggageKg <= 20) totalPrice = priceOver20kg * 0.5;
else totalPrice = priceOver20kg;

if (daysToTrip > 30) totalPrice *= 1.1;
else if (daysToTrip >= 7 && daysToTrip <= 30) totalPrice *= 1.15;
else if (daysToTrip < 7) totalPrice *= 1.4;

Console.WriteLine($"The total price of bags is: {totalPrice * luggageNum:F2} lv.");
