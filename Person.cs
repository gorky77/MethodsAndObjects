using System;

namespace EmployeeApp
{
    public class Person
    {
        // Properties to store first and last names
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to print the full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
