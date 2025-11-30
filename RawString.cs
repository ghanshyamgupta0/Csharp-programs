using System;
using System.Globalization;
public class RawString
{
    public void FormatAndClean()
    {
        string rawValue = " ghaNshYam GupTa ;  20  ; Nepal ;  ghanshyam@gmail.com  ;  9806610679  ;  I Love coding in C# and C#  ;";


        string cleaned = rawValue.Trim();

        string[] items = cleaned.Split(";");
        int i;
        for (i = 0; i < items.Length; i++)
        {
            items[i] = items[i].Trim();

            // Console.WriteLine(items[i]);

        }
         TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        // Convert the string to title case
        string fullname = textInfo.ToTitleCase(items[0]);
        Console.WriteLine($"Fullname : {fullname}");
        string[] firstName = items[0].Split("  ");
        Console.WriteLine($"First Name : {firstName}");

        

    }
}
