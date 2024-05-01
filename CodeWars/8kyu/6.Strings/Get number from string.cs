// https://www.codewars.com/kata/57a37f3cbb99449513000cd8/train/csharp
using System;

namespace Solution
{
    public static class Program
    {
        public static int getNumberFromString(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++) {
                if (Char.IsDigit(s[i])) {
                result *= 10;
                result += s[i] - '0';
                }
            }
            return result;
        }
    }
}
//
using System;
using System.Text.RegularExpressions;
namespace Solution
{
    public static class Program
    {
        public static int getNumberFromString(string s)
        {
            return Int32.Parse(Regex.Replace(s, @"[^\d]", ""));
        }
    }
}
//
using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static int getNumberFromString(string s)
        {
            return int.Parse(string.Concat(s.Where(char.IsDigit)));
        }
    }
}
