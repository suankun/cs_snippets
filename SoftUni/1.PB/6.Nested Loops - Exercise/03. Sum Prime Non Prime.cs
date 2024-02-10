string command = Console.ReadLine();
bool isPrime = false;

int primeSum = 0, nonPrimeSum = 0;
while (command != "stop")
{
    int num = int.Parse(command);
    if (num < 0)
    {
        Console.WriteLine("Number is negative.");
        command = Console.ReadLine();
        continue;
    }
    isPrime = false;
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0)
        {
            isPrime = true;
            break;
        }
    }
    if (isPrime) nonPrimeSum += num;
    else primeSum += num;
    command = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
