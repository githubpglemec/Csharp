using System;

namespace ncit_hari
{
    internal class ProgramInterfacesevenb
    {
        // Interface
        public interface IShape
        {
            // Interface method
            double Area();
        }

        // Concrete class implementing the interface
        class Rectangle : IShape
        {
            // Fields
            private double length;
            private double width;

            // Constructor
            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            // Implementing the method from the interface
            public double Area()
            {
                return length * width;
            }
        }

        static void Main(string[] args)
        {
            // Create an object of the derived class
            Rectangle rectangle = new Rectangle(10, 3);

            // Call the method
            double area = rectangle.Area();
            Console.WriteLine("Area of the rectangle: " + area);

            // Additional information
            Console.WriteLine("\nLab No.: 7");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
