using System;

namespace ncit_hari
{
    internal class GenericClassWithFieldAndMethodEleven<T>
    {
        // Generic field
        private T genericField;

        // Constructor
        public GenericClassWithFieldAndMethodEleven(T value)
        {
            genericField = value;
        }

        // Generic method
        public void Display()
        {
            Console.WriteLine("Generic Field Value: " + genericField);
        }
    }

    internal class ProgramLabEleven
    {
        static void Main(string[] args)
        {
            // Create an instance of the generic class with int type
            GenericClassWithFieldAndMethodEleven<int> intInstance = new GenericClassWithFieldAndMethodEleven<int>(10);
            intInstance.Display();

            // Create an instance of the generic class with string type
            GenericClassWithFieldAndMethodEleven<string> stringInstance = new GenericClassWithFieldAndMethodEleven<string>("Hello");
            stringInstance.Display();

            // Additional information
            Console.WriteLine("\nLab No.: 11");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
