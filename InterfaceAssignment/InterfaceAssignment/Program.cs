using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object.
            Employee sam = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Display the employee's name.
            sam.SayName();

            // Create an interface object using polymorphism.
            IQuittable quittable = sam;

            // Call the Quit method.
            quittable.Quit();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}