using System;

namespace ncit_hari
{
    // Abstract class
    abstract class Shape
    {
        // Abstract method
        public abstract double Area();
    }

    // Concrete class implementing the abstract class
    class Rectangle : Shape
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

        // Implementing the abstract method from the abstract class
        public override double Area()
        {
            return length * width;
        }
    }

    // Program class with the Main method
    class ProgramAbstractClass
    {
        static void Main(string[] args)
        {
            // Create an object of the derived class
            Rectangle rectangle = new Rectangle(5, 3);

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
