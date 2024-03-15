using System;

namespace ncit_hari
{
    internal class PropertyDemo
    {
        // Auto-implemented property
        public int AutoProperty { get; set; }

        // Read-only property
        public int ReadOnlyProperty { get; }

        // Constructor
        public PropertyDemo(int value)
        {
            ReadOnlyProperty = value; // Initialize the read-only property
        }
        public static void Main(string[] args)
        {
            // Creating an object of PropertyDemo
            PropertyDemo obj = new PropertyDemo(10);

            // Assigning value to auto property
            obj.AutoProperty = 20;

            // Displaying values
            Console.WriteLine($"Auto Property Value: {obj.AutoProperty}");
            Console.WriteLine($"Read-Only Property Value: {obj.ReadOnlyProperty}");
        }

        // Additional information
        static PropertyDemo()
        {
            Console.WriteLine("\nLab No.: 2");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
