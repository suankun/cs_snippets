double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double tripCost = 0.0;
string destination = "";
string typeOfAccommodation = "";

if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "summer") tripCost = budget * 0.3;
    else tripCost = budget * 0.7;
}
else if (budget <= 1000) {
    destination = "Balkans";
    if (season == "summer") tripCost = budget * 0.4;
    else tripCost = budget * 0.8;
}
else {
    destination = "Europe";
    tripCost = budget * 0.9;

}

if (season == "summer" && destination != "Europe") typeOfAccommodation = "Camp";
else typeOfAccommodation = "Hotel";

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfAccommodation} - {tripCost:F2}");
