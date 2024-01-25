string type = Console.ReadLine();
int r = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

double total = 0.0;

if (type == "Premiere") total = r * c * 12.00;
else if (type == "Normal") total = r * c * 7.50;
else if (type == "Discount") total = r * c * 5.00;

Console.WriteLine($"{total:F2}");
