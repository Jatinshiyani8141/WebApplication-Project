using System;

namespace MainMethodAssignment
{
    // Create a class
    class MathOperations
    {
        // Create a void method that accepts two integers
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * 2;

            // Display the result
            Console.WriteLine("First number multiplied by 2 = " + result);

            // Display the second integer
            Console.WriteLine("Second number = " + secondNumber);
        }
    }
}