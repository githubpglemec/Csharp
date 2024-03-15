using System;

namespace ncit_hari
{
    internal class ConstructorsDemo
    {
        // Fields
        private int id;
        private string name;

        // Default Constructor
        public ConstructorsDemo()
        {
            Console.WriteLine("Default Constructor is called.");
        }

        // Parameterized Constructor
        public ConstructorsDemo(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine($"Parameterized Constructor is called. ID: {id}, Name: {name}");
        }

        // Copy Constructor
        public ConstructorsDemo(ConstructorsDemo original)
        {
            this.id = original.id;
            this.name = original.name;
            Console.WriteLine($"Copy Constructor is called. ID: {id}, Name: {name}");
        }

        // Main method - entry point of the program
        public static void Main(string[] args)
        {
            // Create an object using the Default Constructor
            ConstructorsDemo defaultObj = new ConstructorsDemo();

            // Create an object using the Parameterized Constructor
            ConstructorsDemo paramObj = new ConstructorsDemo(1, "John");

            // Create an object using the Copy Constructor
            ConstructorsDemo originalObj = new ConstructorsDemo(2, "Alice");
            ConstructorsDemo copyObj = new ConstructorsDemo(originalObj);

            // Static Constructor is called automatically before any instance member is accessed
            // So no need to create an object to call it
            StaticConstructor();

            // Create an object using the Private Constructor
            // ConstructorsDemo privateObj = new ConstructorsDemo("Private Constructor is called.");
            // Uncommenting the above line will generate an error since the constructor is private.
        }

        // Additional information
        static void StaticConstructor()
        {
            Console.WriteLine("Static Constructor is called.");
            Console.WriteLine("\nLab No.: 1");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
