// https://www.codewars.com/kata/5672a98bdbdd995fad00000f/train/csharp
public class Kata
{
    public string Rps(string p1, string p2)
    {
        string winner = "";
        if (p1 == p2) winner = "Draw!";
        else if (p1 == "scissors" && p2 == "paper") winner = "Player 1 won!";
        else if (p1 == "scissors" && p2 == "rock") winner = "Player 2 won!";
        else if (p1 == "rock" && p2 == "paper") winner = "Player 2 won!";
        else if (p1 == "rock" && p2 == "scissors") winner = "Player 1 won!";
        else if (p1 == "paper" && p2 == "scissors") winner = "Player 2 won!";
        else if (p1 == "paper" && p2 == "rock") winner = "Player 1 won!";
        return winner;
    }
}
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public string Rps(string p1, string p2)
    {
        if (p1 == p2)
            return "Draw!";

        if (((p1 == "rock") && (p2 == "scissors")) ||
            ((p1 == "scissors") && (p2 == "paper")) ||
            ((p1 == "paper") && (p2 == "rock")))
        {
            return "Player 1 won!";
        }
        else
        {
            return "Player 2 won!";
        }
    }
}
