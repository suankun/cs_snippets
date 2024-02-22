string name = Console.ReadLine();
int adultTickets = int.Parse(Console.ReadLine());
int kidsTickets = int.Parse(Console.ReadLine());
double adultTicketPrice = double.Parse(Console.ReadLine());
double serviceFee = double.Parse(Console.ReadLine());

double kidsTicketPrice = adultTicketPrice * 0.3;

double adultsTicketPriceWithFee = adultTicketPrice + serviceFee;
double kidsTicketPriceWithFee = kidsTicketPrice + serviceFee;

double total = (adultsTicketPriceWithFee * adultTickets) + (kidsTicketPriceWithFee * kidsTickets);
double totalProfit = total * 0.2;

Console.WriteLine($"The profit of your agency from {name} tickets is {totalProfit:F2} lv.");
