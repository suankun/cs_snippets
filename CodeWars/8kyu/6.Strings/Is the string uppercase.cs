// https://www.codewars.com/kata/56cd44e1aa4ac7879200010b/train/csharp
using System;

public static class StringExtensions
{
    public static bool IsUpperCase(this string text)
    {
        for (int i=0; i<text.Length; i++) {
            if (Char.IsLower(text[i])) return false;
        }
        return true;
    }
}
//
public static class StringExtensions
{
	public static bool IsUpperCase(this string value) 
    {
        return value.ToUpper() == value;
	}
}
