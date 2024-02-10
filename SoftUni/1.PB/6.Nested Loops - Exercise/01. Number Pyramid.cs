int num = int.Parse(Console.ReadLine());
int current = 1;
bool isBigger = false;
for (int rows = 0; rows <= num; rows++)
{
    for (int cols = 0; cols <= rows; cols++)
    {
        Console.Write(current + " ");
        current++;
        if (current > num) { isBigger = true; break;}
    }
    if (isBigger) break;
    Console.WriteLine();
}
