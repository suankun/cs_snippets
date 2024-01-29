// https://www.codewars.com/kata/576b93db1129fcf2200001e6/train/csharp
using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null) return 0;
        int sum = 0;
        Array.Sort(numbers);
        for (int i=1; i<numbers.Length-1; i++) sum += numbers[i];
        return sum;
    }
}
//
using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        return numbers == null || numbers.Length < 2
            ? 0
            : numbers.Sum() - numbers.Max() - numbers.Min();
    }
}