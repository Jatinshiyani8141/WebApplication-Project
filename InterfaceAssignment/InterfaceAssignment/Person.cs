using System;

namespace InterfaceAssignment
{
    // Create the Person class.
    public class Person
    {
        // Store the first name.
        public string FirstName { get; set; }

        // Store the last name.
        public string LastName { get; set; }

        // Display the person's full name.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}