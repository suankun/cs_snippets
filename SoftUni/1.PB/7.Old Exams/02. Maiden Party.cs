const double loveMessage = 0.60;
const double waxRose = 7.20;
const double keychain = 3.60;
const double caricature = 18.20;
const double luckySurprise = 22.00;

double budget = double.Parse(Console.ReadLine());
int loveMessageNum = int.Parse(Console.ReadLine());
int waxRoseNum = int.Parse(Console.ReadLine());
int keychainNum = int.Parse(Console.ReadLine());
int caricatureNum = int.Parse(Console.ReadLine());
int luckySurpriseNum = int.Parse(Console.ReadLine());

double totalPrice = (loveMessage * loveMessageNum) + (waxRose * waxRoseNum) +
                    (keychain * keychainNum) + (caricature * caricatureNum) +
                    (luckySurprise * luckySurpriseNum);

int totalArt = loveMessageNum + waxRoseNum + keychainNum + caricatureNum + luckySurpriseNum;

if (totalArt >= 25) totalPrice *= 0.65; // discount
totalPrice *= 0.9; // hosting

if (totalPrice >= budget)
    Console.WriteLine($"Yes! {totalPrice - budget:f2} lv left.");
else
    Console.WriteLine($"Not enough money! {budget - totalPrice:f2} lv needed.");
