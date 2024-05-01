// https://www.codewars.com/kata/576bb71bbbcf0951d5000044/train/csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input==null || input.Length==0) return new int[0];
        int[] res = new int[2];
        int sum=0, cnt=0;
        for (int i=0; i<input.Length; i++) {
          if (input[i]<=0) sum+=input[i];
          else cnt++;
        }
        res[0]=cnt;
        res[1]=sum;
        return res;
    }
}
//
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if(input == null || !input.Any())
        {
            return new int[] {};
        }
        
        int countPositives = input.Count(n => n > 0);
        int sumNegatives = input.Where(n => n < 0).Sum();

        return new int[] { countPositives, sumNegatives };
    }
}
