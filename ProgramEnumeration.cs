using System;

namespace ncit_hari
{
    internal class ProgramEnumeration
    {
        // Define an enumeration for representing days of the week
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // Display the days of the week using the enumeration
            Console.WriteLine("Days of the week:");
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 8");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
