// https://www.codewars.com/kata/577bd026df78c19bca0002c0/train/csharp
public class Kata
{
    public static string Correct(string text)
    {
        string corrected = "";
        for (int i = 0; i<text.Length; i++) {
            if (text[i] == '5') corrected += 'S';
            else if (text[i] == '0') corrected += 'O';
            else if (text[i] == '1') corrected += 'I';
            else corrected += text[i];
        }
        return corrected;
    }
}
//
public class Kata
{
    public static string Correct(string text)
    {
        return text
        .Replace("0", "O")
        .Replace("1", "I")
        .Replace("5", "S");
    }
}
