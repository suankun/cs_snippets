// https://www.codewars.com/kata/5977618080ef220766000022/train/csharp
using System;

public static class Kata
{
    public static string Usdcny(int usd)
    {
        double result = Math.Round(usd * 6.75, 2);
        return $"{result:f2} Chinese Yuan";
    }
}
//
public static class Kata {
    public static string Usdcny(int usd) {
        return $"{(usd * 6.75f):0.00} Chinese Yuan";
    }
}
