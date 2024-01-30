int n = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int minNum = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int tempNum = int.Parse(Console.ReadLine());
    if (minNum > tempNum) minNum = tempNum;
    if (maxNum < tempNum) maxNum = tempNum;
}

Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");
