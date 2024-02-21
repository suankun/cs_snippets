int tax = int.Parse(Console.ReadLine());

double sneakers = tax * 0.6;
double outfit = sneakers * 0.8;
double ball = outfit / 4.0;
double accessories = ball / 5.0;

double total = tax + sneakers + outfit + ball + accessories;

Console.WriteLine($"{total:F2}");
