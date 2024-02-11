int judges = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

int presentationCnt = 0;
double totalAvg = 0;
while (command != "Finish")
{
    presentationCnt++;
    double avg = 0;
    for (int i = 0; i < judges; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        avg += grade;
        totalAvg += grade;
    }
    Console.WriteLine($"{command} - {avg / judges:F2}.");
    command = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {(totalAvg / (presentationCnt*judges)):F2}.");
