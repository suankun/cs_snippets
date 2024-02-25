double recInSec = double.Parse(Console.ReadLine());
double distInMeters = double.Parse(Console.ReadLine());
double secPerMeters = double.Parse(Console.ReadLine());

double personalTime = (distInMeters * secPerMeters) + (Math.Floor(distInMeters / 50.0) * 30);

if (personalTime < recInSec)
    Console.WriteLine($"Yes! The new record is {personalTime:F2} seconds.");
else
    Console.WriteLine($"No! He was {personalTime - recInSec:F2} seconds slower.");
