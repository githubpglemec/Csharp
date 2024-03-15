using System;

namespace ncit_hari
{
    // Base class
    class BaseClassTwo
    {
        // Method in the base class
        public void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClassTwo");
        }
    }

    // Derived class
    class DerivedClassTwo : BaseClassTwo
    {
        // Method in the derived class that calls base class method using the 'base' keyword
        public void DisplayMessage()
        {
            // Call the base class method using the 'base' keyword
            base.DisplayMessage();
            Console.WriteLine("Message from DerivedClassTwo");
        }
    }

    // Program class with the Main method
    class ProgramBaseTwo
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            DerivedClassTwo derivedObj = new DerivedClassTwo();

            // Call method to display message from the derived class
            derivedObj.DisplayMessage();

            // Additional information
            Console.WriteLine("\nLab No.: 5");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
