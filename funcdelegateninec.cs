using System;

namespace ncit_hari
{
    internal class funcdelegateninec
    {
        // Method to add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to subtract two integers
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Main method
        public static void Main(string[] args)
        {
            // Func delegate declaration (takes two int parameters and returns int)
            Func<int, int, int> operation;

            // Assign the Add method to the delegate
            operation = Add;

            // Call the delegate with arguments 5 and 3
            int result1 = operation(5, 3);
            Console.WriteLine("Addition result: " + result1);

            // Assign the Subtract method to the delegate
            operation = Subtract;

            // Call the delegate with arguments 5 and 3
            int result2 = operation(5, 3);
            Console.WriteLine("Subtraction result: " + result2);

            // Additional information
            Console.WriteLine("\nLab No.: 9");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
