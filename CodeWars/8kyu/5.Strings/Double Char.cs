// https://www.codewars.com/kata/56b1f01c247c01db92000076/train/csharp
public class Kata
{
    public static string DoubleChar(string s)
    {
        string result = "";
        for (int i=0; i<s.Length; i++) {
        result += s[i];
        result += s[i];
        }
        return result;
    }
}
//
using System;
using System.Text;

public class Kata
{
    public static string DoubleChar(string s)
    {
        if (String.IsNullOrEmpty(s))
        {
        throw new ArgumentException("s");
        }
        
        StringBuilder builder = new StringBuilder();
        
        foreach(var value in s)
        {
        builder.Append(value);
        builder.Append(value);
        }
        
        return builder.ToString();
        
    }
}
