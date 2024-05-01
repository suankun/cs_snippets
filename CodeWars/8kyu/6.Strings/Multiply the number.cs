// https://www.codewars.com/kata/5708f682c69b48047b000e07/train/csharp
using System;

public class Kata
{
    public static int Multiply(int number)
    {
        Console.WriteLine(number);
        bool isNegative = false;
        if (number < 0)
        {
            number = -number;
            isNegative = true;
        }
        string toStr = number.ToString();
        int len = toStr.Length;
        double result = number * Math.Pow(5, len);
        if (isNegative)
        {
            result = -result;
        }
        return (int)result;
    }
}
//
using System;
public class Kata
{
    public static int Multiply(int number)
    {
        return (int)(number * (Math.Pow(5, (Math.Abs(number) + "").Length)));
    }
}
