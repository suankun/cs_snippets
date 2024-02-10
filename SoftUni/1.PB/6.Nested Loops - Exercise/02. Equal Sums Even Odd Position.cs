int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    string num = i.ToString();
    int evenSum = 0, oddSum = 0;
    for (int j = 0; j < num.Length; j++)
    {
        int currentDigit = int.Parse(num[j].ToString());
        if (j % 2 == 0) evenSum += currentDigit;
        else oddSum += currentDigit;
    }
    if (evenSum == oddSum) Console.Write(num + ' ');
}
