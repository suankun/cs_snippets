int tax = int.Parse(Console.ReadLine());

double sneakers = tax * 0.60;
double outfit = sneakers * 0.80;
double ball = outfit * 0.25;
double accessories = ball * 0.20;

double totalForAYear = sneakers + outfit + ball + accessories + tax;

Console.WriteLine(totalForAYear);
