// https://www.codewars.com/kata/5761a717780f8950ce001473/train/csharp
using System;

public static class AgeDiff 
{
    public static string CalculateAge(int birth, int yearTo) 
    {
        string result = "";
        if (birth == yearTo) result = "You were born this very year!";
        else if (birth < yearTo) {
            if ((yearTo - birth) == 1) result = "You are " + (yearTo - birth) + " year old.";
            else result = "You are " + (yearTo - birth) + " years old.";
        }
        else {
            if ((birth - yearTo) == 1) result = "You will be born in " + (birth - yearTo) + " year.";
            else result = "You will be born in " + (birth - yearTo) + " years.";
        }
        return result;
    }
}
//
using System;

public static class AgeDiff 
{
    public static string CalculateAge(int birth, int yearTo) 
    {
        if(birth == yearTo)
            return "You were born this very year!";
        
        int x = yearTo - birth;
        string s = Math.Abs(x) > 1 ? "s" : "";
        
        return x > 0 ? $"You are {x} year{s} old." : $"You will be born in {-x} year{s}.";
    }
}
