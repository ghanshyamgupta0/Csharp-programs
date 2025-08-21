using System;

public class HCF
{
    public void FindHcf()
    {
        Console.WriteLine("Enter the numbers to find HCF: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        int num = (a < b) ?a :b;

        for (int i = 1; i <= num; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                result = i;
                
            }
        }

        Console.WriteLine($"HCF is {result}");
    }
}