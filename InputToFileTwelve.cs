using System;
using System.IO;

namespace ncit_hari
{
    internal class InputToFileTwelve
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for input
                Console.WriteLine("Enter text to write to file (press 'Enter' to finish):");

                // Read input from the keyboard
                string input = Console.ReadLine();

                // Create or open a text file for writing
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    // Write input to the file
                    writer.WriteLine(input);
                }

                Console.WriteLine("Text written to file successfully.");

                // Additional information
                Console.WriteLine("\nLab No.: 12");
                Console.WriteLine("Name: Hari Prasad Gyawali");
                Console.WriteLine("Roll No./Section: 06");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
