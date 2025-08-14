using System;
using System.Transactions;

public class StudentResult
{
    public void Display()
    {
        Console.WriteLine("Enter the data of the students: ");
        Console.WriteLine("Enter how many students you want to store");
        int n = Convert.ToInt32(Console.ReadLine());
        double total_marks = 0;
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("Enter the name of the students: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter the name of the students: ");
            total_marks = Convert.ToDouble(Console.ReadLine());

        }

        double gpa = total_marks / 25;
        Console.WriteLine(gpa);
    }
}