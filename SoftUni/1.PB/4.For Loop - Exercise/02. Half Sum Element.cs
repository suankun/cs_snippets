int n = int.Parse(Console.ReadLine());
int sum = 0, max = int.MinValue;

for (int i = 0; i < n; i++)
{
    int temp_num = int.Parse(Console.ReadLine());
    sum += temp_num;
    if (max < temp_num) max = temp_num;
}

int diff = sum - max;
if (diff == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(diff-max)}");
}
