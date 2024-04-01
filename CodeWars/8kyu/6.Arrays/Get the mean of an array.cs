// https://www.codewars.com/kata/563e320cee5dddcf77000158/train/csharp
using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        double sum = 0.0;
        for (int i=0; i<marks.Length; i++) sum += marks[i];
        double avg = sum/marks.Length;
        int result = (int)avg;
        return result;
    }
}
//
using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        return (int)marks.Average();
    }
}
