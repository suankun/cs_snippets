using System;
public static class Kata
{
    public static int Add(int a, int b)
    {
        return a+b;
    }
    public static int Multiply(int a, int b)
    {
        return a*b;
    }
    public static int Divide(int a, int b)
    {
        return a/b;
    }
    public static int Mod(int a, int b)
    {
        return a%b;
    }
    public static double Exponent(double a, int b)
    {
        return Math.Pow(a, b);
    }
    public static int Subt(int a, int b)
    {
        return a-b;
    }
}
//
using System;
public static class Kata
{
    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b; 
    public static int Divide(int a, int b) => a / b;
    public static int Mod(int a, int b) => a % b; 
    public static int Exponent(int a, int b) => (int)Math.Pow(a, b);
    public static int Subt(int a, int b) => a - b;
}
