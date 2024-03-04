int timeForRec = int.Parse(Console.ReadLine());
int scenesNum = int.Parse(Console.ReadLine());
int sceneDuration = int.Parse(Console.ReadLine());

double neededTime = Math.Round((timeForRec * 0.15) + scenesNum * sceneDuration);

if (timeForRec >= neededTime) Console.WriteLine($"You managed to finish the movie on time! You have {timeForRec - neededTime} minutes left!");
else Console.WriteLine($"Time is up! To complete the movie you need {neededTime - timeForRec} minutes.");
