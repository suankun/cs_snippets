double hallRent = double.Parse(Console.ReadLine());

double birthdayCake = hallRent * 0.2;
double beverages = birthdayCake * 0.55;
double animation = hallRent / 3.0;

double total = hallRent + birthdayCake + beverages + animation;

Console.WriteLine($"{total}");
