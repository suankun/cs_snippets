string name = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
int ticketsNum = int.Parse(Console.ReadLine());
double ticketPrice = double.Parse(Console.ReadLine());
int cinemaPercent = int.Parse(Console.ReadLine());

double totalIncome = (ticketsNum * ticketPrice * days) * (1.0 - cinemaPercent / 100.0);

Console.WriteLine($"The profit from the movie {name} is {totalIncome:f2} lv.");
