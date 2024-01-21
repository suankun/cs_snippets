const double nylonPrice = 1.50;
const double paintPrice = 14.50;
const double diluentPrice = 5.00;

int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int diluet = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonTotal = (nylon + 2) * nylonPrice;
double paintTotal = (paint + paint*0.1)  * paintPrice;
double diluentTotal = diluet * diluentPrice;

double totalPrice = nylonTotal + paintTotal + diluentTotal + 0.40;
double totalWork = (totalPrice * 0.3) * hours;

double finalPrice = totalPrice + totalWork;

Console.WriteLine(finalPrice);
