// https://www.codewars.com/kata/5641a03210e973055a00000d/train/csharp
using System;

public class Numbers
{
    public static double TwoDecimalPlaces(double number)
    {
        return Math.Round(number, 2);
    }
}
//
using System;

public class Numbers
{
    public static double TwoDecimalPlaces(double number) => Math.Round(number, 2);
}
//
using System;

public class Numbers
{
    public static double TwoDecimalPlaces(double number)
    {
        return Convert.ToDouble(number.ToString("0.00"));
    }
}
