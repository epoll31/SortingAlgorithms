using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(1);
            int[] data = new int[100];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, data.Length);
            }
            //data = new[] { 5, 4, 3, 2, 1 };

            data.MergeSort();
            ;
        }
    }
}
