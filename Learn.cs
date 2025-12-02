using System;
using System.Transactions;

public struct Student1
{
    public int id;
    public string name;
    public int[] marks = new int[3];

    public Student1(int id, string name, int[] marks)
    {
        this.id = id;
        this.name = name;
        this.marks = marks;
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {id}");
        Console.WriteLine($"$Students Name: {name}");
        for (int a = 0; a < marks.Length; a++)
        { 
            Console.WriteLine($"Marks is{a+1}:  {marks[a]}");
        }
    }
}

public class Learn
{
    public void DisplayData()
    {
        

    Console.WriteLine("Enter the ID of the student: ");
    int id = int.Parse(Console.ReadLine());
    // st.id = id;
    Console.WriteLine("Enter the Name of the student: ");
    string name = Console.ReadLine();
    int[] marks = new int[3];
    int total = 0;
    for (int a = 0; a <3; a++ )
    {
        Console.WriteLine("Enter the Marks of the student: ");
        marks[a] = int.Parse(Console.ReadLine());
        total += marks[a];
    }
    int percent = (total/300) * 100;

    Student1 st = new Student1(id, name, marks);
    st.Display();
    Console.WriteLine($"Total percentage is {st.percent}");
    }
}
