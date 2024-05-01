// https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
using System;

public static class Kata
{
    public static string Solution(string str) 
    {
        string rev = "";
        for (int i=str.Length-1; i>=0; i--) rev += str[i];
        return rev;
    }
}
//
using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str) 
    {
        return new string(str.ToArray().Reverse().ToArray());
    }
}
