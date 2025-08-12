using System;
using System.Diagnostics.CodeAnalysis;

class Student
{
    public void Student1()
    {
        Console.WriteLine("Enter the number of student:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            
            Console.WriteLine("Enter the name of the Student:");
            // string name = Console.ReadLine();
            string name = Console.ReadLine()!;
            double marks;
            double sum = 0;
            double avg = 0;
            for (int j = 1; j < 6; j++)
            {
                Console.WriteLine($"Enter the marks of your subjects {j}:");
                marks = Convert.ToDouble(Console.ReadLine());
                if (marks > 100 || marks < 35)
                {
                    Console.WriteLine(marks);
                    break;
                }
                else
                {
                    sum += marks;
                }
            }
            avg = sum / 5;
            Console.WriteLine($"The average is: {avg}");
            double gpa = avg / 25;
            Console.WriteLine($"Your gpa is {gpa}");
        }
    }
}