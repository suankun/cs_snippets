// https://www.codewars.com/kata/56f699cd9400f5b7d8000b55/train/csharp
public class Kata
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        string temp = arr[0];
        arr[0]=arr[2];
        arr[2]=temp;
        return arr;
    }
}
//
using System.Linq;
public class Kata {
    public static string[] FixTheMeerkat(string[] arr) 
        =>  arr.Reverse().ToArray();
}
