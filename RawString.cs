19630
015979000
Gear lever, wego bel
using System;

class Program
{
    static void Main()
    {
        string raw = "ghaNsshYam GupTa ; 17  ; NePal  ;  ghanshyam@gmail.com  ;  9806666777  ; I love coding in C# and C#       ";

        // Split the raw string by ';'
        string[] parts = raw.Split(';');

        // Trim each part
        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].Trim();
        }

        // Extract values
        string fullNameRaw = parts[0];
        string ageRaw = parts[1];
        string countryRaw = parts[2];
        string emailRaw = parts[3];
        string numberRaw = parts[4];
        string favRaw = parts[5];

        // Format full name
        string[] nameParts = fullNameRaw.Split(' ');
        string firstName = Capitalize(nameParts[0]);
        string lastName = Capitalize(nameParts[1]);
        string fullName = firstName + " " + lastName;

        // Validate email (simple check)
        bool validEmail = emailRaw.Contains("@") && emailRaw.Contains(".");

        // Format country
        string country = Capitalize(countryRaw);

        // Remove extra spaces in favourite programming text
        string favProgramming = favRaw.Trim();

        // Output
        Console.WriteLine("----- Cleaned & Formatted Data -----");
        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + ageRaw);
        Console.WriteLine("Country: " + country);
        Console.WriteLine("Email: " + emailRaw);
        Console.WriteLine("Valid Email: " + validEmail);
        Console.WriteLine("Phone Number: " + numberRaw);
        Console.WriteLine("Favourite Programming: " + favProgramming);
    }

    // Helper method to capitalize first letter
    static string Capitalize(string text)
    {
        text = text.ToLower().Trim();
        return char.ToUpper(text[0]) + text.Substring(1);
    }
}
