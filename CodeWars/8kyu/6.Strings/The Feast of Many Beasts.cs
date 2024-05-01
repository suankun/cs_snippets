// https://www.codewars.com/kata/5aa736a455f906981800360d/train/csharp
public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        return (beast[0] == dish[0] && beast[beast.Length-1] == dish[dish.Length-1]);
    }
}
