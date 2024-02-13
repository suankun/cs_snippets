// https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp
namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            double res = 0.0;
            switch (operation) {
                case '+': res = value1+value2; break;
                case '-': res = value1-value2; break;
                case '*': res = value1*value2; break;
                case '/': res = value1/value2; break;
            }
            return res;
        }
    }
}
//
using System;
using System.Data;

public static class Program
{
    public static double basicOp(char op, double a, double b)
    {
        return Convert.ToDouble(new DataTable().Compute($"{a}{op}{b}", ""));
    }
}
