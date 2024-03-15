using System;

namespace ncit_hari
{
    internal class PrivateConstructorDemo
    {
        // Private Constructor
        private PrivateConstructorDemo(string message)
        {
            Console.WriteLine(message);
        }

        // Main method - entry point of the program
        public static void Main(string[] args)
        {
            // Creating an object using a private constructor
            // PrivateConstructorDemo obj = new PrivateConstructorDemo("Private Constructor is called.");
             //This line will generate an error since the constructor is private.
        }

        // Additional information
        static PrivateConstructorDemo()
        {
            Console.WriteLine("\nLab No.: 5");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
