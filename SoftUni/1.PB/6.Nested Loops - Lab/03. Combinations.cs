int n = int.Parse(Console.ReadLine());
int validCombination = 0;

for (int i = 0; i <= n; i++)
    for (int j = 0; j <= n; j++)
        for (int k = 0; k <= n; k++)
            if (i+j+k==n) validCombination++;

Console.WriteLine(validCombination);
