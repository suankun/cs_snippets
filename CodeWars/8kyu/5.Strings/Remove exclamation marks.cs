// https://www.codewars.com/kata/57a0885cbb9944e24c00008e/train/csharp
public class Kata
{
    public static string RemoveExclamationMarks(string s)
    {
        string result = "";
        for (int i=0; i < s.Length; i++){
            if (s[i] != '!') {
                result += s[i];
            }
        }
        return result;
    }
}
//
using System;
public class Kata
{
    public static string RemoveExclamationMarks(string s)
    {
        return s.Replace("!", "");
    }
}
