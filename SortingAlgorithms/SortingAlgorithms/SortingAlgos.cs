using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class SortingAlgos
    {
        public static void BubbleSort<T>(this T[] data) where T : IComparable
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
        }

        public static void SelectionSort<T>(this T[] data) where T : IComparable
        {
            for (int i = 0; i < data.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < data.Length; j++)
                {
                    if (data[j].CompareTo(data[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    T temp = data[i];
                    data[i] = data[minIndex];
                    data[minIndex] = temp;
                }
            }
        }

        public static void InsertionSort<T>(this T[] data) where T : IComparable
        {
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (data[j].CompareTo(data[j - 1]) < 0)
                    {
                        T temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
