double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processor = int.Parse(Console.ReadLine());
int memory = int.Parse(Console.ReadLine());

double videoCardsTotalPrice = videoCards * 250.00;
double processorPrice = videoCardsTotalPrice * 0.35;
double processorTotalPrice = processor * processorPrice;
double memoryPrice = videoCardsTotalPrice * 0.1;
double momoryTotalPrice = memory * memoryPrice;

double total = videoCardsTotalPrice + processorTotalPrice + momoryTotalPrice;
        
if (videoCards > processor) total *= 0.85;

if (budget >= total) Console.WriteLine($"You have {budget-total:F2} leva left!");
else Console.WriteLine($"Not enough money! You need {total-budget:F2} leva more!");
