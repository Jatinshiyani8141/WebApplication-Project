using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOp = new MathOperations();

            // Ask the user for the first number
            Console.WriteLine("Enter the first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number
            Console.WriteLine("Enter the second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the method using positional parameters
            Console.WriteLine("\nPositional Parameter Call:");
            mathOp.PerformOperation(num1, num2);

            // Call the method using named parameters
            Console.WriteLine("\nNamed Parameter Call:");
            mathOp.PerformOperation(firstNumber: num1, secondNumber: num2);

            // Keep the console open
            Console.ReadLine();
        }
    }
}