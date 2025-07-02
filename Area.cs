using System;

public class Area
{
    public void CalculateArea(double length, double width)
    {
        double area = length * width;
        Console.WriteLine($"The area of the rectangle is: {area}");
    }

    public void CalculatePerimeter(double radius)
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"The area of the circle is: {area}");
    }
}