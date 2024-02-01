// https://www.codewars.com/kata/57f780909f7e8e3183000078/train/csharp
public class Kata
{
    public static int Grow(int[] x)
    {
        int sum=1;
        for (int i=0; i<x.Length; i++) sum*=x[i];
        return sum;
    }
}
//
using System.Linq;

public class Kata
{
    public static int Grow(int[] x)
    {
        return x.Aggregate((a,b) => a*b);
    }
}
