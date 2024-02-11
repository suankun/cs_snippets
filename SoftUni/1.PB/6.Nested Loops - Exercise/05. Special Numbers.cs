int n = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{
    string num = i.ToString();
    bool isSpecial = true;
    for (int j = 0; j < num.Length; j++)
    {
        int currentDigit = num[j] - '0';
        if (currentDigit == 0) { isSpecial = false; break; }
        if (n % currentDigit == 0) { continue; }
        else { isSpecial = false; break; }
    }
    if (isSpecial) Console.Write(num + ' ');
}
