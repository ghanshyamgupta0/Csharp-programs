using System;

class JaggedArray2D
{
    public void Array2D()
    {
        Console.Write("Enter how many 2D arrays you want in the jagged array: ");
        int rows = int.Parse(Console.ReadLine());

      
        int[][][] jaggedArray = new int[rows][][];

        for (int i = 0; i < rows; i++)
        {

            Console.Write("Enter number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int col = int.Parse(Console.ReadLine());

            jaggedArray[i] = new int[row][col];

            for (int x = 0; x < row; x++)
            {
                jaggedArray[i][x] = new int[col];
                Console.WriteLine($"Enter {col} values for row {x}:");

                for (int y = 0; y < col; y++)
                {
                    jaggedArray[i][x][y] = int.Parse(Console.ReadLine());
                }
            }
        }

        Console.WriteLine("\nDisplaying Jagged Array of 2D Arrays:");

        // Display all elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"\n2D Array {i}:");

            for (int x = 0; x < jaggedArray[i].Length; x++)
            {
                for (int y = 0; y < jaggedArray[i][x].Length; y++)
                {
                    Console.Write(jaggedArray[i][x][y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
