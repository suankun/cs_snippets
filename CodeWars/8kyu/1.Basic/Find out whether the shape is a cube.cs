// https://www.codewars.com/kata/58d248c7012397a81800005c/train/cpp
bool is_cube(int volume, int side)
{
    return volume==side*side*side&&volume>0;
}
//
bool is_cube(int volume, int side)
{
    return side > 0 && volume > 0 && side * side * side == volume;
}
