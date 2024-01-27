// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/train/csharp
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string res = "";
      for (int i=0; i<n; i++) {
        res += s;
      }
      return res;
    }
  }
}
//
namespace Solution
{
  using System;
  using System.Linq;
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return String.Concat(Enumerable.Repeat(s, n));
    }
  }
}
