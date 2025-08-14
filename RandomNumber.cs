using System;
using System.Globalization;
public class RandomNumber
{
    public void RandomNum()
    {
        Random random = new Random();
        int secretNum = random.Next(1, 101);
        bool isCorrect = true;
        int i = 1;
        while (isCorrect)
        {
            Console.WriteLine("Guess a random number between 1 to 100:");
            int guess = Convert.ToInt32(Console.ReadLine());
            int diffrence = Math.Abs(secretNum - guess);
            int num = 10;
            if (diffrence <= num)
            {
                Console.WriteLine("Your guess is low by 10.");
                i++;
            }
            else if (guess > secretNum || diffrence >= num)
            {
                Console.WriteLine("Your Guess is High.");
                i++;
            }
            else
            {
                Console.WriteLine($"Congratulations! Your Guess is Correct. You attempt in {i}");

                isCorrect = false;
            }
        }
        // Console.WriteLine($"{secretNum}");

    }
}