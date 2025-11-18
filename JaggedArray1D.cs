
using System;

class JaggedArray1D
{
    public void Array1D()
    {
        Console.Write("Enter how many rows (1D arrays) you want: ");
        int rows = int.Parse(Console.ReadLine());

        // Create jagged array
        int[][] jaggedArray = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter size of row {i}: ");
            int size = int.Parse(Console.ReadLine());

            jaggedArray[i] = new int[size];

            Console.WriteLine($"Enter {size} elements for row {i}:");

            for (int j = 0; j < size; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Displaying the jagged array
        Console.WriteLine("\nJagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
