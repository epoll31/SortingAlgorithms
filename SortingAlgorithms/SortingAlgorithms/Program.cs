using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(1);
            int[] data = new int[50];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, data.Length);
            }
            //data = new[] { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            data.QuickSort(PartitionType.Hoare);

            Console.CursorTop = 0;
            for (int i = 0; i < data.Length; i++)
            {
                Console.CursorLeft = 2;
                Console.WriteLine($" >> {data[i]}");
            }
        }
    }
}
