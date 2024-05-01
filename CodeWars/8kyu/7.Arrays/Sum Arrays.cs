// https://www.codewars.com/kata/53dc54212259ed3d4f00071c/train/csharp
public class Kata
{
    public static double SumArray(double[] array)
    {
        double sum=0.0;
        for (int i=0; i<array.Length; i++) sum+=array[i];
        return sum;
    }
}
//
using System.Linq;

public class Kata
{
    public static double SumArray(double[] array)
    {
        return array.Sum();
    }
}
