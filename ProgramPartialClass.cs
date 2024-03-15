using System;

namespace ncit_hari
{
    // Partial class
    public partial class Employee
    {
        // Fields
        private string name;
        private int age;

        // Constructor
        public Employee(string n, int a)
        {
            name = n;
            age = a;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Partial class (continued)
    public partial class Employee
    {
        // Additional fields and methods can be defined here
    }

    // Program class with the Main method
    internal class ProgramPartialClass
    {
        static void Main(string[] args)
        {
            // Create an instance of the partial class
            Employee employee = new Employee("John Doe", 30);

            // Display employee details
            employee.DisplayDetails();

            // Additional information
            Console.WriteLine("\nLab No.: 8");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
