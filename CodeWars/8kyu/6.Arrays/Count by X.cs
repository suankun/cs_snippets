// https://www.codewars.com/kata/5513795bd3fafb56c200049e/train/csharp
using System;

public static class Kata
{
    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];
        int counter = x;
        for (int i=0; i<n; i++) {
        z[i] = counter;
        counter+=x;
        }
        return z;
    }
}
//
using System;
using System.Linq;

public static class Kata
{
    public static int[] CountBy(int x, int n)
    {
        return Enumerable.Range(1, n).Select(i => i * x).ToArray();    
    }
}
