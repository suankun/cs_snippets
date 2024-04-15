// https://www.codewars.com/kata/54147087d5c2ebe4f1000805/train/csharp
using System;

public class Kata
{
    public static void If(bool condition, Action func1, Action func2)
    {
        if (condition == true) func1();
        else func2();
    }
}
