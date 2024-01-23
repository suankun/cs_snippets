double recordInSec = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double secPerMeter = double.Parse(Console.ReadLine());

double slowingDawn = Math.Floor(distanceInMeters / 15.0) * 12.5;
double totalSec = (distanceInMeters * secPerMeter) + slowingDawn;

if (totalSec<recordInSec) Console.WriteLine($"Yes, he succeeded! The new world record is {totalSec:F2} seconds.");
else Console.WriteLine($"No, he failed! He was {totalSec-recordInSec:F2} seconds slower.");
