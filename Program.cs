using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize the Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123 // Example ID, could be any integer
            };

            // Call the SayName method to print the full name
            employee.SayName();

            Console.ReadLine();
        }
    }
}

