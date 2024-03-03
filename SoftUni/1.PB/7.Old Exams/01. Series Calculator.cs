string name = Console.ReadLine();
int seasons = int.Parse(Console.ReadLine());
int episodes = int.Parse(Console.ReadLine());
double episodeDuratioin = double.Parse(Console.ReadLine());

double ads = episodeDuratioin * 0.2;

double episodeTotalDuration = episodeDuratioin + ads;

double specialEpisodesAddDuration = seasons * 10;

double totalTime = Math.Floor(episodeTotalDuration * episodes * seasons + specialEpisodesAddDuration);

Console.WriteLine($"Total time needed to watch the {name} series is {totalTime} minutes.");
