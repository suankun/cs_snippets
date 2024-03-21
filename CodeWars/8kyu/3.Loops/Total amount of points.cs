// https://www.codewars.com/kata/5bb904724c47249b10000131/train/csharp
using System.Linq;

public static class Kata {
    public static int TotalPoints(string[] games) {
        int points = 0;
        for (int i = 0; i < games.Length; i++) {
            if (games[i][0] > games[i][2]) points += 3;
            else if (games[i][0] == games[i][2]) points += 1;
        }
        return points;
    }
}
//
using System.Linq;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
}
