// https://www.codewars.com/kata/54edbc7200b811e956000556/train/csharp
using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int count = 0;
        for (int i=0; i<sheeps.Length; i++){
        if (sheeps[i] == true) count++;
        }
        return count;
    }
}
//
using System;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(s => s);
    }
}
