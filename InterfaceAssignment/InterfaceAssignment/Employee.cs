using System;

namespace InterfaceAssignment
{
    // Employee inherits from Person and implements IQuittable.
    public class Employee : Person, IQuittable
    {
        // Store the employee ID.
        public int Id { get; set; }

        // Implement the Quit method.
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }
}