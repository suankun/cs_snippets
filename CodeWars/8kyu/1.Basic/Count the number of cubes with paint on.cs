// https://www.codewars.com/kata/5763bb0af716cad8fb000580/train/csharp
using System;  
  
  public static class Kata
    {
        public static int CountSquares(int cuts)
        {
            if (cuts == 0) {
                return 1;
            }

            int total_cubes = (cuts + 1) * (cuts + 1) * (cuts + 1);
            int cubes_with_red_face = (cuts - 1) * (cuts - 1) * (cuts - 1);

            return total_cubes - cubes_with_red_face;
        }
    }
//
using System;  
  
  public static class Kata
    {
        public static int CountSquares(int cuts)
        {
            return (int)(cuts == 0 ? 1 : Math.Pow(cuts+1 , 3) - Math.Pow(cuts-1 , 3));
        }
    }
//
using System;  
  
public static class Kata
{
    public static int CountSquares(int n)
    {
        return n == 0 ? 1 : 6*n*n + 2;
    }
}
