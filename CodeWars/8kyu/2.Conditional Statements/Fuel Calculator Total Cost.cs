// https://www.codewars.com/kata/57b58827d2a31c57720012e8/train/csharp
using System;

public class Kata
{
    public static double FuelPrice(double litres, double pricePerLitre)
    {
        if (litres >= 10) pricePerLitre -= 0.25;
        else if (litres >= 8) pricePerLitre -= 0.20;
        else if (litres >= 6) pricePerLitre -= 0.15;
        else if (litres >= 4) pricePerLitre -= 0.10;
        else if (litres >= 2) pricePerLitre -= 0.05;
        
        double totalPrice = litres * pricePerLitre;
        return Math.Round(totalPrice * 100.0) / 100.0;
        // Math.Round(totalPrice, 2);
    }
}
//
using System;

public class Kata
{
    public static double FuelPrice(double l, double p) => Math.Round(l * (p - Math.Min(0.25, 0.05 * Math.Floor(l / 2))), 2);
}