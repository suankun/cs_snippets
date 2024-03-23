string player1 = Console.ReadLine();
string player2 = Console.ReadLine();

int player1Points = 0, player2Points = 0;
bool isNumberWars = false;
string winnerName = "";
int winnerPoints = 0;
string command = Console.ReadLine();
while (command != "End of game")
{
    int player1Card = int.Parse(command);
    int player2Card = int.Parse(Console.ReadLine());

    if (player1Card == player2Card)
    {
        Console.WriteLine("Number wars!");
        player1Card = int.Parse(Console.ReadLine());
        player2Card = int.Parse(Console.ReadLine());
        if (player1Card > player2Card)
        {
            winnerName = player1;
            winnerPoints = player1Points;
        }
        else
        {
            winnerName = player2;
            winnerPoints = player2Points;
        }
        Console.WriteLine($"{winnerName} is winner with {winnerPoints} points");
        isNumberWars = true;
        break;
    }

    if (player1Card > player2Card)
    {
        player1Points += player1Card - player2Card;
    }
    else
    {
        player2Points += player2Card - player1Card;
    }

    command = Console.ReadLine();
}

if (!isNumberWars)
{
    Console.WriteLine($"{player1} has {player1Points} points");
    Console.WriteLine($"{player2} has {player2Points} points");
}
