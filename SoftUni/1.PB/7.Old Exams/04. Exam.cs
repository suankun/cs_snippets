int studentsNum = int.Parse(Console.ReadLine());

int group1 = 0, group2 = 0, group3 = 0, group4 = 0;
double totalGrades = 0;
for (int i = 0; i < studentsNum; i++)
{
    double currentGrade = double.Parse(Console.ReadLine());
    if (currentGrade >= 5.00) group1++;
    else if (currentGrade >= 4.00) group2++;
    else if (currentGrade >= 3.00) group3++;
    else  group4++;

    totalGrades += currentGrade;
}

Console.WriteLine($"Top students: {(1.0 * group1 / studentsNum) * 100.0:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {(1.0 * group2 / studentsNum) * 100.0:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {(1.0 * group3 / studentsNum) * 100.0:f2}%");
Console.WriteLine($"Fail: {(1.0 * group4 / studentsNum) * 100.0:f2}%");
Console.WriteLine($"Average: {1.0 * totalGrades / studentsNum:f2}");
