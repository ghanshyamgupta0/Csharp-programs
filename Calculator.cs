using System.ComponentModel;
using System.Numerics;

public class Calculator
{
    public void Calculate()
    {
        Console.WriteLine("Enter first numbers:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second numbers:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        int i = 1;
        // while (i <= 5)
        // {
            Console.WriteLine("Enter an operator (+, -, *, /, %):");
            char op = Convert.ToChar(Console.ReadLine());
            double add = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            // double divide = num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero.");
            double mod = num1 % num2;

            double result = op switch
            {
                '+' => add,
                '-' => sub,
                '*' => mul,
                '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
                '%' => mod
            };

            Console.WriteLine($"Result = {result}");
            // i++;
        // }
        Console.WriteLine("Thanks for using my Calculator App");

    }
    
    public void RunProgram() {
        bool isAgain = true;
        while (isAgain) {
            Console.WriteLine("1. CalculateAgain \n2. Exit");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Calculate();
                    break;

                case 2:
                    isAgain = false;
                    break;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
    
}