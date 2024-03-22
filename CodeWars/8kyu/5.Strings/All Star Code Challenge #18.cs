// https://www.codewars.com/kata/5865918c6b569962950002a1/train/csharp
class Kata
{
    public static int StrCount(string str, char letter)
    {
        int cnt = 0;
        for (int i = 0; i < str.Length; i++) {
            if (str[i] == letter) cnt++;
        }
        return cnt;
    }
}
//
using System.Linq;

class Kata
{
    public static int StrCount(string str, char letter)
    {
        return str.Where(x => x == letter).Count();
    }
}
