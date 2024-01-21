double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double amount = deposit + months * ((deposit * (percent / 100)) / 12);

Console.WriteLine(amount);
