// https://www.codewars.com/kata/5302d846be2a9189af0001e4/train/csharp
public class Kata
{
    public static string SayHello(string[] name, string city, string state)
    {
        string result = "Hello,";
        for (int i=0; i<name.Length; i++) result += " " + name[i];
        result += "! Welcome to " + city + ", " + state + "!";
        return result;
    }
}
//
public class Kata
{
    public static string SayHello(string[] name, string city, string state) =>
        $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
}