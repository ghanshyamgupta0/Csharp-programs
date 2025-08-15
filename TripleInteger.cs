using System;

public class TripleInteger
{
    public void Compute()
    {
        Console.WriteLine("Enter Two numbers: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        Console.WriteLine($"The sum is {sum}");
        if (num1 == num2)
        {
            double result = sum * 3;

            Console.WriteLine($"The Triple of the sum is {result}");
        }
    }
}