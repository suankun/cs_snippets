string name = Console.ReadLine();
int episode = int.Parse(Console.ReadLine());
int lunchBreak = int.Parse(Console.ReadLine());

double timeForLunch = lunchBreak / 8.0;
double timeForBreak = lunchBreak / 4.0;
double timeLeft = lunchBreak - timeForLunch - timeForBreak;

if (timeLeft >= episode)
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft-episode)} minutes free time.");
else
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(episode-timeLeft)} more minutes.");
