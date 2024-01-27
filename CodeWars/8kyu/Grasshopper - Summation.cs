// https://www.codewars.com/kata/55d24f55d7dd296eb9000030/train/csharp
using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int sum=0;
      for (int i=1; i<=num; i++) {
        sum+=i;
      }
      return sum;
    }
}
