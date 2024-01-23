string figure = Console.ReadLine();
if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F3}");
}
else if (figure == "rectangle")
{
    double side_a = double.Parse(Console.ReadLine());
    double side_b = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", side_a * side_b);
}
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", Math.PI * (r * r));
}
else if (figure == "triangle")
{
    double h = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("{0:F3}", h * b / 2);
}
