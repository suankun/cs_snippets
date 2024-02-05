int fails = int.Parse(Console.ReadLine());

int totalGrades = 0, poorGrades = 0, totalExams = 0;
string lastProblem = "";
string command = Console.ReadLine();
while (command != "Enough")
{
    int grade = int.Parse(Console.ReadLine());
    if (grade <= 4) poorGrades++;
    if (poorGrades == fails) break;

    totalExams++;
    totalGrades += grade;

    lastProblem = command;
    command = Console.ReadLine();
}

double avg = (double)totalGrades / totalExams;
if (command == "Enough")
{
    Console.WriteLine($"Average score: {avg:F2}");
    Console.WriteLine($"Number of problems: {totalExams}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
else
{
    Console.WriteLine($"You need a break, {poorGrades} poor grades.");    
}
