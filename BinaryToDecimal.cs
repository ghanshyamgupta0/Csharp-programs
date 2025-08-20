using System;

public class BinaryToDecimal
{
    public void ConvertToDecimal()
    {
        Console.WriteLine("Input a binary number: ");
        int binary = Convert.ToInt32(Console.ReadLine());
        int originalBinary = binary;
        int count = 0;
        int digit = 0;
        double result = 0;
    

        while (binary > 0)
        {
            
            digit = binary % 10;
            if (digit == 1)
            {
                result += digit * Math. Pow(2, count);
                
            }
            binary /= 10;
            count++;
        }

        Console.WriteLine($"The binary number is: {result}");
    }
}