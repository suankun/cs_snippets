int n = int.Parse(Console.ReadLine());

int sum = 0;
for (int  i=0; i<n; i++)
{
    int temp_num = int.Parse(Console.ReadLine());
    sum += temp_num;
}

Console.WriteLine(sum);
