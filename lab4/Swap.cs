// WAP in C# that swap two numbers using callby value? Does the Swap work outside the method? Why?

public class Swap
{
    public void SwapNumbers(int a, int b)
    {
        int x = a;
        a = b;
        b = x;
        Console.WriteLine("Swapping numbers by call by value method....");
        Console.WriteLine($"Swapped value of a = {b} and b = {a}");

    }
}