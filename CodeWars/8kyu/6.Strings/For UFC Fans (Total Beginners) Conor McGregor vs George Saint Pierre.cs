// https://www.codewars.com/kata/582dafb611d576b745000b74/train/csharp
using System;

public static class Kata
{
    public static string Quote(string fighter)
    {
        string name = fighter.ToLower();
        if (name == "george saint pierre") return "I am not impressed by your performance.";
        return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
    }
}
//
using System;

public static class Kata
{
    public static string Quote(string fighter)
    {
        return fighter.Equals("Conor McGregor", StringComparison.CurrentCultureIgnoreCase) 
            ? "I'd like to take this chance to apologize.. To absolutely NOBODY!" 
            : "I am not impressed by your performance.";
    }
}
