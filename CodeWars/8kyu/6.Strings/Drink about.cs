// https://www.codewars.com/kata/56170e844da7c6f647000063/train/csharp
public class Kata
{
    public static string PeopleWithAgeDrink(int old)
    {
        string beverage = "";
        if (old < 14) beverage = "drink toddy";
        else if (old < 18) beverage = "drink coke";
        else if (old < 21) beverage = "drink beer";
        else if (old >= 21) beverage = "drink whisky";
        return beverage;
    }
}
//
public class Kata
{
    public static string PeopleWithAgeDrink(int old)
    {
        return "drink " + (old < 14 ? "toddy" : old < 18 ? "coke" : old < 21 ? "beer" : "whisky");
    }
}
