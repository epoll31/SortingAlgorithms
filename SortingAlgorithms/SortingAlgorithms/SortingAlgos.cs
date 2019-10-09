using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class SortingAlgos
    {
        private static void Swap<T>(this T[] data, int index1, int index2) where T : IComparable
        {
            T temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public static void BubbleSort<T>(this T[] data) where T : IComparable
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[i].CompareTo(data[j]) < 0)
                    {
                        data.Swap(i, j);
                    }
                }
            }
        }

        public static void SelectionSort<T>(this T[] data) where T : IComparable
        {
            for (int i = 0; i < data.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j].CompareTo(data[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    data.Swap(i, minIndex);
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
                        data.Swap(j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void MergeSort<T>(this T[] data) where T : IComparable
        {
            data.MergeSort(0, data.Length);
        }
        private static void MergeSort<T>(this T[] data, int min, int max) where T : IComparable
        {
            int length = max - min;
            if (length == 1)
            {
                return;
            }

            data.MergeSort(min, min + length / 2);
            data.MergeSort(min + length / 2, max);

            data.Merge(min, max);
        }
        private static void Merge<T>(this T[] data, int min, int max) where T : IComparable
        {
            int length = max - min;
            int mid = min + length / 2;
            int midIndex = mid;
            int minIndex = min;

            while (minIndex < mid && midIndex < max)
            {
                if (data[minIndex].CompareTo(data[midIndex]) < 0)
                {
                    minIndex++;
                    continue;
                }

                for (int i = midIndex - 1; i >= minIndex; i--)
                {
                    data.Swap(i, i + 1);
                }

                minIndex++;
                midIndex++;
                mid++;
            }
        }

        public static void QuickSort<T>(this T[] data, PartitionType partition = PartitionType.Lomuto) where T : IComparable
        {
            switch (partition)
            {
                case PartitionType.Lomuto:
                    data.QuickSortLomutoPartition(0, data.Length);
                    break;
                case PartitionType.Hoare:
                    data.QuickSortHoarePartition();
                    break;
            }
        }

        private static void QuickSortLomutoPartition<T>(this T[] data, int minIndex, int maxIndex) where T : IComparable
        {
            if (maxIndex - minIndex <= 1)
            {
                return;
            }
            int pivotIndex = maxIndex - 1;
            int wallIndex = minIndex;
            for (int i = minIndex; i < pivotIndex; i++)
            {
                if (data[i].CompareTo(data[pivotIndex]) < 0)
                {
                    data.Swap(i, wallIndex);
                    wallIndex++;
                }
            }
            data.Swap(wallIndex, pivotIndex);

            data.QuickSortLomutoPartition(minIndex, wallIndex);
            data.QuickSortLomutoPartition(wallIndex + 1, maxIndex);
        }

        private static void QuickSortHoarePartition<T>(this T[] data) where T : IComparable
        {
        }
    }

    public enum PartitionType
    {
        Lomuto = 0,
        Hoare = 1
    }
}
