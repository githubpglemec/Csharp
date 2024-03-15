using System;

namespace ncit_hari
{
    internal class ProgramMultipleInheritance
    {
        // Interface for Shape
        public interface IShape
        {
            double Area();
        }

        // Interface for Color
        public interface IColor
        {
            string GetColor();
        }

        // Concrete class implementing IShape and IColor
        public class Rectangle : IShape, IColor
        {
            private double length;
            private double width;
            private string color;

            public Rectangle(double l, double w, string c)
            {
                length = l;
                width = w;
                color = c;
            }

            public double Area()
            {
                return length * width;
            }

            public string GetColor()
            {
                return color;
            }
        }

        static void Main(string[] args)
        {
            // Create an object of the Rectangle class
            Rectangle rectangle = new Rectangle(5, 3, "Red");

            // Call methods from both interfaces
            double area = rectangle.Area();
            string color = rectangle.GetColor();

            // Output the results
            Console.WriteLine("Area of the rectangle: " + area);
            Console.WriteLine("Color of the rectangle: " + color);

            // Additional information
            Console.WriteLine("\nLab No.: 7");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
