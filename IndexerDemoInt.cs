using System;

namespace ncit_hari // Ensure the namespace matches the file name
{
    class IndexerDemoInt
    {
        private int[] data = new int[5];

        // Indexer when index is of int type
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        static void Main(string[] args)
        {
            IndexerDemoInt demo = new IndexerDemoInt();

            // Using indexers with int type index
            demo[0] = 10;
            demo[1] = 20;
            demo[2] = 30;

            // Displaying values
            Console.WriteLine("Values with int index:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Index {i}: {demo[i]}");
            }

            // Additional information
            Console.WriteLine("\nLab No.: 4");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
