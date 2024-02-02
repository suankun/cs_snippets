// https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
using System;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int sum=0;
        for (int i=0; i<arr.Length; i++) if (arr[i] > 0) sum+=arr[i];
        return sum;
    }
}
//
using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Where(x => x > 0).Sum();
    }
}
//
using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Sum(c => (c < 0 ? 0 : c));
    }
}
