int pages = int.Parse(Console.ReadLine());
int pagesForHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hoursToReadPages = pages / pagesForHour;
int daysToReadPages = hoursToReadPages / days;

Console.WriteLine(daysToReadPages);
