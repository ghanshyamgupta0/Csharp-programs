class UserPreferences
{
    public void user(int age, double height, bool notifications)
    {
        
        Console.WriteLine($"Age: {age}, Height: {height}, Notifications: {notifications}");

    }
    
    static void Main(string[] args)
    {
        // Create a new instance of the UserPreferences class
        var userPreferences = new UserPreferences();
        
        // Prompt the user for their preferences
        Console.WriteLine("Setting user preferences...");
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your height in meters:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Do you want notifications? (true/false):");
        bool notifications = bool.Parse(Console.ReadLine());

        // Call the user method to set preferences
        userPreferences.user(age, height, notifications);
        
        // Print a message indicating the end of the program
        Console.WriteLine("User preferences set successfully.");
    }
}