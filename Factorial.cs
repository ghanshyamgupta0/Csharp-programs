// WAP to find factorial of n given number

using System;
public class Factorial
{
    public int FindFact(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            // Console.WriteLine("Hello");
            return n * FindFact(n - 1);
        }
    }

    public void FindFactorial()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int i;
        int fact = 1;
        for (i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine($"Factorial is: {fact}");

    }
}