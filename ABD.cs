using System;

public class ABC{
    public void DisplayData () {
        String name = "GhanshyamGupta";

        // name = "Ghanshyam Sha.";
        int length = name.Length;
        Console.WriteLine($"Your Name is {name}");
        Console.WriteLine($"Length of string is {length}");
        
        int first = name[name.IndexOf(" ") + 1];
        int last = name[length - 1];
        int middle = name[]
        // String = str1 = name.SubString(start, end);
        Console.WriteLine($"Accessing indexOf t is {name.IndexOf("t")}");
        // Console.WriteLine($"Accessing indexOf t is {name.IndexOf(" ", start) - start}");
        Console.WriteLine($"First string:{first}");
        Console.WriteLine($"Last string:{last}");
        
        // Console.WriteLine(name.IndexOf("Gupta"));
    }
}
