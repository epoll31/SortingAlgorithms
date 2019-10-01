using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class SortingAlgos
    {
        public static T[] BubbleSort<T>(this T[] data) where T : IComparable
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[i].CompareTo(data[j]) < 0)
                    {
                        T temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            return data;
        }
    }
}
