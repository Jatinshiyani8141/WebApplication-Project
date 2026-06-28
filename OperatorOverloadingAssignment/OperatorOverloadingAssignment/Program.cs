using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "Jatin",
                LastName = "Shiyani"
            };

            // Create the second employee
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Jason",
                LastName = "Russel"
            };

            // Compare the employees
            Console.WriteLine(employee1 == employee2);

            Console.ReadLine();
        }
    }
}