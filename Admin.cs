using System; 
public class Admin {
    public void ValidateLogin()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        // Logical AND for admin login
        if (username == "admin" && password == "1234")
        {
            Console.WriteLine("Admin login successful!");
        }
        // Logical OR for guest or admin login
        else if (username == "admin" || username == "guest")
        {
            Console.WriteLine("Guest or Admin login allowed (password not required for guest).");
        }
        else
        {
            Console.WriteLine("Invalid credentials.");
        }
    }
}