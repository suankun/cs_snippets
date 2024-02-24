int bitcoins = int.Parse(Console.ReadLine());
double yuan = double.Parse(Console.ReadLine());
double commission = double.Parse(Console.ReadLine());

double euro = (((bitcoins * 1168.0) / 1.95) + (((yuan * 0.15) * 1.76) / 1.95)) * (1.0 - (commission / 100.0));

Console.WriteLine($"{euro:F2}");
