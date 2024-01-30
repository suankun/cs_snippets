int n = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < n; i++)
{
    int tempNum = int.Parse(Console.ReadLine());
    leftSum += tempNum;
}

for (int i = 0; i < n; i++)
{
    int tempNum = int.Parse(Console.ReadLine());
    rightSum += tempNum;
}

if (leftSum == rightSum) Console.WriteLine($"Yes, sum = {leftSum}");
else Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
