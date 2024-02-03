string actorsName = Console.ReadLine();
double accademyPoints = double.Parse(Console.ReadLine());
int judgesNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < judgesNumber; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());
    double currentPoints = judgeName.Length * judgePoints / 2.0;
    accademyPoints += currentPoints;

    if (accademyPoints > 1250.5) break;
}

if (accademyPoints > 1250.5) Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {accademyPoints:F1}!");
else Console.WriteLine($"Sorry, {actorsName} you need {1250.5 - accademyPoints:F1} more!");
