using System;

// ReSharper disable InconsistentNaming
namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(ref array[minIndex], ref array[i]);
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            SelectionSortRecursive(array);
        }

        public static void SelectionSortRecursive(this int[]? array, int index = 0)
        {
            if (index >= array!.Length - 1)
            {
                return;
            }

            int minIndex = index;
            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            if (minIndex != index)
            {
                Swap(ref array[minIndex], ref array[index]);
            }

            SelectionSortRecursive(array, index + 1);
        }
    }
}
