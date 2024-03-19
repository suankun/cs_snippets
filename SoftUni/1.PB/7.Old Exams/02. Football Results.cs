string firstMatch = Console.ReadLine();
string secondMatch = Console.ReadLine();
string thirdMatch = Console.ReadLine();

int won = 0, lost = 0, drawn = 0;

if (firstMatch[0] > firstMatch[2]) won++;
else if (firstMatch[0] < firstMatch[2]) lost++;
else drawn++;

if (secondMatch[0] > secondMatch[2]) won++;
else if (secondMatch[0] < secondMatch[2]) lost++;
else drawn++;

if (thirdMatch[0] > thirdMatch[2]) won++;
else if (thirdMatch[0] < thirdMatch[2]) lost++;
else drawn++;

Console.WriteLine($"Team won {won} games.");
Console.WriteLine($"Team lost {lost} games.");
Console.WriteLine($"Drawn games: {drawn}");
