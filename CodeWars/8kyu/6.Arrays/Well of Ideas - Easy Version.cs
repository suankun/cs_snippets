// https://www.codewars.com/kata/57f222ce69e09c3630000212/train/csharp
public class Kata
{
    public static string Well(string[] x)
    {
        int cnt = 0;
        for (int i = 0; i < x.Length; i++) {
        if (x[i] == "good") cnt++;
        }
        
        string result = "";
        if (cnt > 2) result = "I smell a series!";
        else if (cnt > 0) result = "Publish!";
        else result = "Fail!";
        
        return result;
    }
}
