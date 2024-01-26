// https://www.codewars.com/kata/557b5e0bddf29d861400005d/train/csharp
using System;
public static class Kata
{
	public static double Converter(int mpg)
	{
        const double GAL_TO_LITERS = 4.54609188;
        const double MILE_TO_KM = 1.609344;

        double kpl = (mpg * MILE_TO_KM) / GAL_TO_LITERS;
        double res = Math.Round(kpl, 2);
        return res;
	}
}
//
using System;

public static class Kata
{
  
  private const double km_per_mile = 1.609344;
  private const double litres_per_gallon = 4.54609188;
  
	public static double Converter(int mpg)
	{
		return Math.Round(mpg * km_per_mile / litres_per_gallon, 2);
	}
}
