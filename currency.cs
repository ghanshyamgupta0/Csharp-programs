// using System;
class Currency
{
    public void convert()
    {
        // Conversion logic here
        System.Console.WriteLine("Converting currency...");
        Console.WriteLine("Enter the amount in Nepali:");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Press \n 1 to convert indiaan rupees \n 2 to convert to US dollars \n 3 to convert japanese yen ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                double conversionRate1 = 1.65; // Example conversion rate from Nepali to indian rupees
                double convertedAmount1 = amount * conversionRate1;
                Console.WriteLine($"Converted amount in Indian Rupees: {convertedAmount1}");
                break;
            case 2:
                double conversionRate2 = 0.0073; // Example conversion rate from Nepali to Us dollars
                double convertedAmount2 = amount * conversionRate2;
                Console.WriteLine($"Converted amount in Us Dollars: {convertedAmount2}"); break;
            case 3:
                double conversionRate3 = 1.06; // Example conversion rate from Nepali to Japanese Yen
                double convertedAmount3 = amount * conversionRate3;
                Console.WriteLine($"Converted amount in Japanese Yen: {convertedAmount3}"); break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }

    static void Main(string[] args)
    {
        // Create a new instance of the Currency class
        var currency = new Currency();

        // Call the convert method to perform currency conversion
        currency.convert();

        // Print a message indicating the end of the program
        Console.WriteLine("Currency conversion completed.");
    }
}

/* Output:

PS D:\C# Program\class1> dotnet run
Converting currency...
Enter the amount in Nepali:
45000
Press
 1 to convert indiaan rupees
 2 to convert to US dollars
 3 to convert japanese yen
2
Converted amount in Us Dollars: 328.5
Currency conversion completed.
PS D:\C# Program\class1>

*/