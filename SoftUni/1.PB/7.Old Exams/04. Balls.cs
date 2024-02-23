int N = int.Parse(Console.ReadLine());

int totalPoints = 0, red = 0, orange = 0, yellow = 0, white = 0, black = 0, other = 0;

for (int i = 0; i < N; i++)
{
    string currentBall = Console.ReadLine();
    switch (currentBall)
    {
        case "red": totalPoints += 5; red++; break;
        case "orange": totalPoints += 10; orange++;  break;
        case "yellow": totalPoints += 15; yellow++;  break;
        case "white": totalPoints += 20; white++;  break;
        case "black": totalPoints /= 2; black++;  break;
        default: other++; break;
    }
}

Console.WriteLine($"Total points: {totalPoints}");
Console.WriteLine($"Red balls: {red}");
Console.WriteLine($"Orange balls: {orange}");
Console.WriteLine($"Yellow balls: {yellow}");
Console.WriteLine($"White balls: {white}");
Console.WriteLine($"Other colors picked: {other}");
Console.WriteLine($"Divides from black balls: {black}");
