public class Triangle
{
    public void Display()
    {
        Console.WriteLine("Calculating Side and area of a triangle...");
        Console.WriteLine("Enter the length of the first side:");
        double side1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side:");
        double side2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the third side:");
        double side3 = double.Parse(Console.ReadLine());
        
        if (side1 + side2 > side3 && 
            side1 + side3 > side2 && 
            side2 + side3 > side1)
        {
            Console.WriteLine("The triangle is valid.");
            double perimeter = side1 + side2 + side3;
            double semiPerimeter = perimeter / 2;
            double area = Math.Sqrt(semiPerimeter * 
                (semiPerimeter - side1) * 
                (semiPerimeter - side2) * 
                (semiPerimeter - side3));
            Console.WriteLine($"The area of the triangle is: {area}");
        }
        else
        {
            Console.WriteLine("The lengths provided do not form a valid triangle.");
        }
    }        
}