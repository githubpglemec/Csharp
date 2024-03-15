using System;

namespace ncit_hari
{
    // Base class
    class BaseClassThree
    {
        // Field in the base class
        protected int baseField;

        // Base class constructor
        public BaseClassThree(int value)
        {
            baseField = value;
        }

        // Method in the base class
        public void DisplayBaseField()
        {
            Console.WriteLine($"Base Field: {baseField}");
        }
    }

    // Derived class
    class DerivedClassThree : BaseClassThree
    {
        // Derived class constructor
        public DerivedClassThree(int value) : base(value)
        {
            // Call the base class constructor using the 'base' keyword
            // and pass the value to initialize the baseField
        }
    }

    // Program class with the Main method
    class ProgramBaseThree
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClassThree derivedObj = new DerivedClassThree(10);

            // Call method to display base class field from the derived class
            derivedObj.DisplayBaseField();

            // Additional information
            Console.WriteLine("\nLab No.: 5");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
