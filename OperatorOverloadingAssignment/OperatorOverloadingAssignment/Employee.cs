using System;

namespace OperatorOverloadingAssignment
{
    // Create the Employee class
    public class Employee
    {
        // Employee ID
        public int Id { get; set; }

        // Employee first name
        public string FirstName { get; set; }

        // Employee last name
        public string LastName { get; set; }

        // Compare two Employee objects using their Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // Required when overloading ==
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            Employee employee = obj as Employee;

            if (employee == null)
            {
                return false;
            }

            return Id == employee.Id;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}