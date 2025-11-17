using System;

class ParamsExample
{
    // Method using params
    static double FindAverage(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return (double)sum / numbers.Length;
    }

    public void Display()
    {
        // Calling method with 5 integers
        double avg = FindAverage(10, 20, 30, 40, 50);

        Console.WriteLine("Average = " + avg);
    }
}
