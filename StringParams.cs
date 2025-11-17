Here’s a simple C# program that uses params and passes each word as a separate argument:

using System;

class StringParams
{
    // Method using params
    public void DisplayMessage(params string[] words)
    {
        foreach (string w in words)
        {
            Console.Write(w + " ");
        }
    }

    public void Display()
    {
        DisplayMessage("Hey", "doggy", "where", "are", "you?");
    }
}
