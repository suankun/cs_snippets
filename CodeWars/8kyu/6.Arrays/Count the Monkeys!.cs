public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        int[] array = new int[n];
        for (int i=1; i<=n; i++) {
        array[i-1] = i;
        }
        return array;
    }
}
//
using System.Linq;

public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        return Enumerable.Range(1, n).ToArray();
    }
}
