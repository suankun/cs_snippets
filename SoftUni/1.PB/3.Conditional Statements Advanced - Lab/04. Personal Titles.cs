double age = double.Parse(Console.ReadLine());
char sex = char.Parse(Console.ReadLine());

if (age < 16)
{
    if (sex == 'm') Console.WriteLine("Master");
    else Console.WriteLine("Miss");
}
else
{
    if (sex == 'm') Console.WriteLine("Mr.");
    else Console.WriteLine("Ms.");
}
