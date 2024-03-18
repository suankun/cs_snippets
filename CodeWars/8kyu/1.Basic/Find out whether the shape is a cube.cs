// https://www.codewars.com/kata/58d248c7012397a81800005c/train/csharp
namespace CubeCheck {
    using System;
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            return side > 0 && volume > 0 && side * side * side == volume;
        }
    }
}
//
namespace CubeCheck {
    using System;
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            return (Math.Pow(side,3)==volume && side>0);
        }
    }
}
