// https://www.codewars.com/kata/57f24e6a18e9fad8eb000296/train/csharp
using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    string result="";
    int check = nb_petals % 6;
    switch (check)
    {
      case 1: result = "I love you"; break;
      case 2: result = "a little"; break;
      case 3: result = "a lot"; break;
      case 4: result = "passionately"; break;
      case 5: result = "madly"; break;
      case 0: result = "not at all"; break;
    }
    return result;
  }
}
//
using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
    return new string[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"}[(nb_petals - 1) % 6];
  }
}
