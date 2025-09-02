// Wap that calculate the square of a numbers using call by value does the original numbers change?
// Modify the above program to use call by reference (ref) so the original number gets squared.

public class Square
{
    public void FindSquare(ref int number)
    {
        int square = number * number;
        number = square;
        Console.WriteLine($"Square of number is {square}");
    }
}