using System;


namespace ncit_hari
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][] {
                new int[] { 11, 21, 56, 78 },
                new int[] { 2, 5, 6, 7, 98, 5 },
                new int[] { 2, 5 }
            };

            // Traverse array elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Additional information
            Console.WriteLine("\nLab No.: 3");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
