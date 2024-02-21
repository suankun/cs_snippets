// https://www.codewars.com/kata/586c1cf4b98de0399300001d/train/csharp
using System;

public static class Game
{
    public static float Combat(float health, float damage)
    {
        return health-damage >= 0 ? health-damage : 0;
    }
}
//
using System;

public static class Game
{
    public static float Combat(float health, float damage)
    {
        return Math.Max(0, health - damage);
    }
}
