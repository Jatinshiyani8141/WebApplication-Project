using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");

            // Read the weight input from the user and convert it to an integer
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the package weight is greater than 50
            if (weight > 50)
            {
                // Display error message if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // End the program
                return;
            }

            // Ask the user to enter the package width
            Console.WriteLine("Please enter the package width:");

            // Read and convert width input
            int width = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the package height
            Console.WriteLine("Please enter the package height:");

            // Read and convert height input
            int height = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the package length
            Console.WriteLine("Please enter the package length:");

            // Read and convert length input
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate the total dimensions
            int dimensionsTotal = width + height + length;

            // Check if the total dimensions are greater than 50
            if (dimensionsTotal > 50)
            {
                // Display error message if package is too large
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // End the program
                return;
            }

            // Calculate the shipping quote
            // Formula: (width × height × length × weight) ÷ 100
            decimal quote = (width * height * length * weight) / 100m;

            // Display the final shipping quote formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Thank the user
            Console.WriteLine("Thank you!");
        }
    }
}