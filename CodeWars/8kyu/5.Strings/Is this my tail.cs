// https://www.codewars.com/kata/56f695399400f5d9ef000af5/train/csharp
public class Kata
{
    public static bool CorrectTail(string body, string tail)
    {
        string sub = body.Substring((body.Length-1), tail.Length);
        
        if (sub == tail)
            return true;
        else
            return false;
    }
}
