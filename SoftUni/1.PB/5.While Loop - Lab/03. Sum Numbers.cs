int num = int.Parse(Console.ReadLine());
int sum = 0;

while (sum < num)
{
    int tempNum = int.Parse(Console.ReadLine());
    sum += tempNum;
}

Console.WriteLine($"{sum}");
