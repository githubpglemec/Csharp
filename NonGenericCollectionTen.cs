using System;
using System.Collections;

namespace ncit_hari
{
    internal class NonGenericCollectionTen
    {
        static void Main(string[] args)
        {
            // Create a non-generic ArrayList collection
            ArrayList list = new ArrayList();

            // Add elements to the collection
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);

            // Display elements in the collection
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 10");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
