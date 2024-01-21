int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegetarian = int.Parse(Console.ReadLine());

double chikenPrice = chicken * 10.35;
double fishPrice = fish * 12.40;
double vegetarianPrice = vegetarian * 8.15;

double totalPrice = chikenPrice + fishPrice + vegetarianPrice;

double dessert = totalPrice * 0.2;

double finalPrice = totalPrice + dessert + 2.5;

Console.WriteLine(finalPrice);
