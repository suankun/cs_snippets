int l = int.Parse(Console.ReadLine());
int w = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = (l * w * h) * 0.001;
double neededLiters = volume - (volume * (percent / 100.0));

Console.WriteLine(neededLiters);
