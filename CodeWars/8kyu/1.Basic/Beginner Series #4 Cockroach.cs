// https://www.codewars.com/kata/55fab1ffda3e2e44f00000c6/train/csharp
using System;
public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        double result = x*27.7778;
        return (int)Math.Floor(result);
    }
}
//
using System;
public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        return (int) (x *  27.778);
    }
}
