// WAP to Find user given numbers of prime numbers.

using System;

public class Nprime
{
    public void FindPrime()
    {
        Console.WriteLine("Enter how many prime numbers you want to find:");
        int count = Convert.ToInt32(Console.ReadLine());
        if (count <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        int found = 0;

        for (int num = 2; found <= count; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num);
                found++;
            }
            if (found >= count)
            {
                break;
            }
        }
    }

}
