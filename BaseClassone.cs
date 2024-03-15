using System;

namespace ncit_hari
{
    // Base class
    class BaseClassone
    {
        // Field in the base class
        protected string baseField = "Base Field";

        // Method in the base class
        public void DisplayBaseField()
        {
            Console.WriteLine($"Base Field: {baseField}");
        }
    }

    // Derived class
    class DerivedClass : BaseClassone
    {
        // Method in the derived class that accesses the base class field using the 'base' keyword
        public void DisplayBaseFieldFromDerived()
        {
            // Accessing the base class field using the 'base' keyword
            Console.WriteLine($"Accessing Base Field from Derived: {base.baseField}");
        }
    }

    // Program class with the Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClass derivedObj = new DerivedClass();

            // Call method to display base class field from the derived class
            derivedObj.DisplayBaseFieldFromDerived();

            // Additional information
            Console.WriteLine("\nLab No.: 5");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
