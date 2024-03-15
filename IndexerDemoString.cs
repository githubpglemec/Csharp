using System;

namespace ncit_hari // Ensure the namespace matches the file name
{
    class IndexerDemoString
    {
        private string[] data = new string[5];

        // Indexer when index is of string type
        public string this[string index]
        {
            get { return data[Convert.ToInt32(index)]; }
            set { data[Convert.ToInt32(index)] = value; }
        }

        static void Main(string[] args)
        {
            IndexerDemoString demo = new IndexerDemoString();

            // Using indexers with string type index
            demo["0"] = "A";
            demo["1"] = "B";
            demo["2"] = "C";

            // Displaying values
            Console.WriteLine("Values with string index:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Index {i}: {demo[i.ToString()]}");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 4");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
