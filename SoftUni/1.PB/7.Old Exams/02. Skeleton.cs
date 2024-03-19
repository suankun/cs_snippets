int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());
double chuteLength = double.Parse(Console.ReadLine());
int secPer100Meters = int.Parse(Console.ReadLine());

int controlInSeconds = minutes * 60 + seconds;
double delay = chuteLength / 120.0 * 2.5;

double totalTime = (chuteLength / 100.0) * secPer100Meters - delay;

if (totalTime <= controlInSeconds)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {totalTime:f3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {totalTime - controlInSeconds:f3} second slower.");
}
