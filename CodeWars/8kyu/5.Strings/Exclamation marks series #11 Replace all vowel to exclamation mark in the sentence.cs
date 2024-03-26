// https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed/train/csharp
using System;

public static class Kata
{
    public static string Replace(string s)
    {
        string clear_from_vowels = "";
        string vowels = "aeiouAEIOU";
        int len = s.Length;
        for (int i = 0; i < len; i++) {
            bool found = vowels.Contains(s[i]);
            if (found) clear_from_vowels += '!';
            else clear_from_vowels += s[i];
        }
        return clear_from_vowels;
    }
}
//
using System.Linq;

public static class Kata
{
    public static string Replace(string s)
    {
        return string.Concat(s.Select(x => "aeiouAEIOU".Contains(x) ? '!' : x));
    }
}
