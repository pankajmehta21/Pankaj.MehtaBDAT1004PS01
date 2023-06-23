using System;

class Program
{
    static void Main()
    {
        double a, b, c;

        Console.WriteLine("Enter the lengths of the sides of the triangle:");
        Console.Write("Side a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Side b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Side c: ");
        c = double.Parse(Console.ReadLine());

        double area = TriangleArea(a, b, c);
        Console.WriteLine("The area of the triangle is: " + area);
    }

    static double TriangleArea(double a, double b, double c)
    {
        // Calculate the semi-perimeter
        double s = (a + b + c) / 2;

        // Calculate the area using Heron's formula
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        return area;
    }
}
