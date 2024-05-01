// https://www.codewars.com/kata/55f73f66d160f1f1db000059/train/csharp
public class Kata
{
    public static string CombineNames(string firstName, string lastName) {
         return firstName + " " + lastName;
    }
}
//
public static class Kata
{
    public static string CombineNames(string firstPart, string secondPart)
    {
        return $"{firstPart} {secondPart}";
    }
}
//
public class Kata{
    public static string CombineNames(string a, string b) => a + " " + b;  
}