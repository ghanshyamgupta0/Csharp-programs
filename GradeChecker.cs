using System;

class GradeChecker {
    public void code() {
        Console.WriteLine("Grade Checker.... ");
        // mark1
        Console.WriteLine("Enter the marks of first subject:");
        double mark1 = Convert.ToDouble(Console.ReadLine());
        // mark2
        Console.WriteLine("Enter the marks of second subject:");
        double mark2 = Convert.ToDouble(Console.ReadLine());
        // mark3
        Console.WriteLine("Enter the marks of third subject:");
        double mark3 = Convert.ToDouble(Console.ReadLine());
        // Average mark
        double mark = (mark1 + mark2 + mark3)/3;

        string grade = mark switch {
            >= 90 => "Grade A+",
            >= 75 => "Grade A",
            >= 50 => "Grade B",
            _ => "Fail"
        };

        // Display Grade
        Console.WriteLine($"Your grade is {grade}");
    }
}