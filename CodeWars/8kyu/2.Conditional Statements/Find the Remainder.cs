// https://www.codewars.com/kata/524f5125ad9c12894e00003f/train/csharp
using System;

public class Kata
{
    public static int Remainder(int a, int b)
    {
        return Math.Max(a, b)%Math.Min(a,b);
    }
}
//
using System;

public class Kata
{
    public static int Remainder(int a, int b) =>
        a > b ? a % b : b % a;
}
