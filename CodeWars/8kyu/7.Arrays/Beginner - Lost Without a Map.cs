// https://www.codewars.com/kata/57f781872e3d8ca2a000007e/train/csharp
public class Kata
{
    public static int[] Maps(int[] x)
    {
        for (int i=0; i<x.Length; i++) x[i]*=2;
        return x;
    }
}
//
using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(e => e*2).ToArray();
    }
}
