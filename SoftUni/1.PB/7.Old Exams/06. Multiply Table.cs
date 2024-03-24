int num = int.Parse(Console.ReadLine());

int firstMultiplier = num % 10;
int secondMultiplier = (num / 10) % 10;
int thirdMultiplier = num / 100;

for (int i = 1; i <= firstMultiplier; i++)
    for (int j = 1; j <= secondMultiplier; j++)
        for (int k = 1; k <= thirdMultiplier; k++)
            Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
