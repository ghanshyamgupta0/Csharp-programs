using System;

public class Arithmetic
{
    public void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"Sum: {sum}");
    }

    public void Subtract(int a, int b)
    {
        int difference = a - b;
        Console.WriteLine($"Difference: {difference}");
    }

    public void Multiply(int a, int b)
    {
        int product = a * b;
        Console.WriteLine($"Product: {product}");
    }

    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            double quotient = (double)a / b;
            Console.WriteLine($"Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}