string studentName = Console.ReadLine();
double avg = 0.0;
int grade = 0;
int fails = 0;

while (grade < 12)
{
    double assessment = double.Parse(Console.ReadLine());
    if (assessment < 4.0) fails++;
    if (fails >= 2) break;
    avg += assessment;
    grade++;
}

if (grade == 12) Console.WriteLine($"{studentName} graduated. Average grade: {avg / 12.0:F2}");
else Console.WriteLine($"{studentName} has been excluded at {grade} grade");
