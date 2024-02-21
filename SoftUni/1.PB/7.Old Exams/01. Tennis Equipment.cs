double tennisRacketPrice = double.Parse(Console.ReadLine());
int tennisRacketsNum = int.Parse(Console.ReadLine());
int sneakersNum = int.Parse(Console.ReadLine());

double tennisRacketTotal = tennisRacketsNum * tennisRacketPrice;

double sneakersPrice = tennisRacketPrice / 6.0;
double sneakersTotal = sneakersNum * sneakersPrice;

double remainingEquipmentPrice = (tennisRacketTotal + sneakersTotal) * 0.2;

double totalPrice = tennisRacketTotal + sneakersTotal + remainingEquipmentPrice;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice * (1.0 / 8.0))}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice * (7.0 / 8.0))}");
