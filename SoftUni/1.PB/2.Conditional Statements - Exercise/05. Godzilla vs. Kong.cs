double budget = double.Parse(Console.ReadLine());
int actorsNumber = int.Parse(Console.ReadLine());
double outfitPrice = double.Parse(Console.ReadLine());

double decor = budget*0.1;
double outfitTotalPrice = actorsNumber*outfitPrice;
if (actorsNumber>=150) outfitTotalPrice*=0.9;

double total = decor+outfitTotalPrice;

if (budget<total) {
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {total-budget:F2} leva more.");
}
else {
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget-total:F2} leva left.");
}