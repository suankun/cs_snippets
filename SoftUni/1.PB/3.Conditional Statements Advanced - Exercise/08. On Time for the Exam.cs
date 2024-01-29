int exam_h = int.Parse(Console.ReadLine());
int exam_m = int.Parse(Console.ReadLine());
int arrival_h = int.Parse(Console.ReadLine());
int arrival_m = int.Parse(Console.ReadLine());

int exam_total_min = exam_h * 60 + exam_m;
int arrival_total_min = arrival_h * 60 + arrival_m;
int diff = 0;

if (exam_total_min < arrival_total_min) Console.WriteLine("Late");
else if (exam_total_min <= arrival_total_min + 30) Console.WriteLine("On time");
else if (exam_total_min > arrival_total_min + 30) Console.WriteLine("Early");

if (exam_total_min < arrival_total_min)
{
    if (arrival_total_min - exam_total_min < 60)
    {
        Console.Write($"{arrival_total_min - exam_total_min} minutes ");
    }
    else
    {
        diff = arrival_total_min - exam_total_min;
        Console.Write($"{diff / 60}:");
        if (diff % 60 < 10) Console.Write("0");
        Console.Write($"{diff % 60} hours ");
    }
    Console.WriteLine("after the start");
}
else if (exam_total_min > arrival_total_min)
{
    if (exam_total_min - arrival_total_min < 60)
    {
        Console.Write($"{exam_total_min - arrival_total_min} minutes ");
    }
    else
    {
        diff = exam_total_min - arrival_total_min;
        Console.Write($"{diff / 60}:");
        if (diff % 60 < 10) Console.Write("0");
        Console.Write($"{diff % 60} hours ");
    }
    Console.WriteLine("before the start");
}
