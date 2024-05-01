// https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad/train/csharp
using System.Linq;
namespace Solution
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            for (int i=0; i<input.Length; i++) input[i] *= -1;
            return input;
        }
    }
}
//
using System.Linq;
namespace Solution
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            return input.Select(n => -n).ToArray();
        }
    }
}