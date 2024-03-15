using System;

namespace ncit_hari
{
    // Delegate declaration
    public delegate void MyDelegate(string message);

    // Class to demonstrate delegates
    public class Delegateninea
    {
        // Method to be assigned to the delegate
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message from the delegate: " + message);
        }

        // Main method
        public static void Main(string[] args)
        {
            // Create an instance of the delegate
            MyDelegate delegateInstance = new MyDelegate(DisplayMessage);

            // Call the delegate
            delegateInstance("Hello, World!");

            // Additional information
            Console.WriteLine("\nLab No.: 9");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
