const double pens = 5.80;
const double markers = 7.20;
const double cleaner = 1.20;

int pensNumber = int.Parse(Console.ReadLine());
int markersNumber = int.Parse(Console.ReadLine());
int cleanerLiters = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());

double pensPrice = pensNumber * pens;
double markersPrice = markersNumber * markers;
double cleanerPrice = cleanerLiters *  cleaner;
double totalPrice = pensPrice + markersPrice + cleanerPrice;

double finalPrice = totalPrice - (totalPrice * (discountPercent / 100.0));

Console.WriteLine(finalPrice);
