using System;
using System.Collections.Generic;

namespace ncit_hari
{
    internal class GenericCollectionTenb
    {
        static void Main(string[] args)
        {
            // Create a generic List collection of integers
            List<int> numbers = new List<int>();

            // Add elements to the collection
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Display elements in the collection
            Console.WriteLine("Elements in the List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 10");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
