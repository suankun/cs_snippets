// https://www.codewars.com/kata/65ba420888906c1f86e1e680/train/csharp
public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
        if ((x1 == 0 && x2 == 0) || (y1 == 0 && y2 == 0)) return x1 * y2 == x2 * y1;
        else return (x1 * y2 == x2 * y1);
    }
}
//
public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
        return x1 * y2 == y1 * x2;
    }
}
