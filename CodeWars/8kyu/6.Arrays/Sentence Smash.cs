// https://www.codewars.com/kata/53dc23c68a0c93699800041d/train/csharp
public class Kata
{
    public static string Smash(string[] words)
    {
        string result = "";
        for (int i = 0; i < words.Length; i++) {
            result += words[i];
            if (i != words.Length-1) result += ' ';
        }
        return result;
    }
}
//
using System;

public class Kata
{
    public static string Smash(string[] words) =>
        String.Join(" ", words);
}
//
public class Kata
{
    public static string Smash(string[] words)
    {
        return string.Join(" ", words);
    }
}
