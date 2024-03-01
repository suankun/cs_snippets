// https://www.codewars.com/kata/56b1f01c247c01db92000076/train/csharp
public class Kata
{
    public static string DoubleChar(string s)
    {
        string result = "";
        for (int i=0; i<s.Length; i++) {
        result += s[i];
        result += s[i];
        }
        return result;
    }
}
