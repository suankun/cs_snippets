int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());

string evenOdd = "";
int result = 0;

if (op == '+')
{
    result = N1 + N2;
    if (result % 2 == 0) evenOdd = "even";
    else evenOdd = "odd";
    Console.WriteLine($"{N1} + {N2} = {result} - {evenOdd}");
}
else if (op == '-')
{
    result = N1 - N2;
    if (result % 2 == 0) evenOdd = "even";
    else evenOdd = "odd";
    Console.WriteLine($"{N1} - {N2} = {result} - {evenOdd}");
}
else if (op == '*')
{
    result = N1 * N2;
    if (result % 2 == 0) evenOdd = "even";
    else evenOdd = "odd";
    Console.WriteLine($"{N1} * {N2} = {result} - {evenOdd}");
}
else if (op == '/')
{
    double res = N1*1.0 / N2;
    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
    else Console.WriteLine($"{N1} / {N2} = {res:F2}");
}
else if (op == '%')
{
    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
    else Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
}
