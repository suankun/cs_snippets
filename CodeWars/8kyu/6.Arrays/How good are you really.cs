// https://www.codewars.com/kata/5601409514fc93442500010b/train/csharp
public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        double sum = 0;
        for (int i = 0; i < ClassPoints.Length; i++) sum += ClassPoints[i];
        sum += YourPoints;
        return sum/(ClassPoints.Length+1)>YourPoints ? false : true;
    }
}
