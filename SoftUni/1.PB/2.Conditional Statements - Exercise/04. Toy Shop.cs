const double puzzle = 2.60;
const double puppet = 3.00;
const double bear = 4.10;
const double minion = 8.20;
const double truck = 2.00;

double tripCost = double.Parse(Console.ReadLine());
int puzzleNum = int.Parse(Console.ReadLine());
int puppetNum =  int.Parse(Console.ReadLine());
int bearNum =  int.Parse(Console.ReadLine());
int minionNum =  int.Parse(Console.ReadLine());
int truckNum =  int.Parse(Console.ReadLine());

double totalAmount = (puzzleNum*puzzle) + (puppetNum*puppet) + (bearNum*bear) + (minionNum*minion) + (truckNum*truck);
int totalToys = puzzleNum+puppetNum+bearNum+minionNum+truckNum;

if (totalToys >= 50) totalAmount *= 0.75;  // 25% discount if the toys are equal or more than 50
totalAmount *= 0.9;  // rent of the store

if (totalAmount >= tripCost) Console.WriteLine($"Yes! {totalAmount - tripCost:F2} lv left.");
else Console.WriteLine($"Not enough money! {tripCost - totalAmount:F2} lv needed.");
