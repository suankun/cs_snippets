string movieName = Console.ReadLine();
int studentTotal = 0, standardTotal = 0, kidTotal = 0;
while (movieName != "Finish")
{
    int freeSeats = int.Parse(Console.ReadLine());
    int student = 0, standard = 0, kid = 0;
    for (int i = 0; i < freeSeats; i++)
    {
        string ticketType = Console.ReadLine();
        if (ticketType == "End") break;
        if (ticketType == "student") student++;
        else if (ticketType == "standard") standard++;
        else if (ticketType == "kid") kid++;
    }
    studentTotal += student; standardTotal += standard; kidTotal += kid;
    double currTotalTicket = student + standard + kid;
    Console.WriteLine($"{movieName} - {currTotalTicket / freeSeats * 100.0:F2}% full.");
    movieName = Console.ReadLine();
}

double totalTickets = studentTotal + standardTotal + kidTotal;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{studentTotal / totalTickets * 100.0:F2}% student tickets.");
Console.WriteLine($"{standardTotal / totalTickets * 100.0:F2}% standard tickets.");
Console.WriteLine($"{kidTotal / totalTickets * 100.0:F2}% kids tickets.");
