using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionTimeSorting
{
    class MergeSortClass
    {
        public MergeSortClass()
        {

        }

        public int[] mergeSort(int[] array)
        {
            if (array.Length > 1)
            {
                // Merge sort the first half
                int[] firstHalf = new int[array.Length / 2];
                Array.Copy(array, 0, firstHalf, 0, array.Length / 2);
                mergeSort(firstHalf);

                // Merge sort the second half
                int secondHalfLength = array.Length - array.Length / 2;
                int[] secondHalf = new int[secondHalfLength];
                Array.Copy(array, array.Length / 2,
                  secondHalf, 0, secondHalfLength);
                mergeSort(secondHalf);

                // Merge firstHalf with secondHalf into list
                merge(firstHalf, secondHalf, array);
            }

            return array;
        }

        public void merge(int[] list1, int[] list2, int[] temp)
        {
            int current1 = 0; // Current index in list1
            int current2 = 0; // Current index in list2
            int current3 = 0; // Current index in temp

            while (current1 < list1.Length && current2 < list2.Length)
            {
                if (list1[current1] < list2[current2])
                    temp[current3++] = list1[current1++];
                else
                    temp[current3++] = list2[current2++];
            }

            while (current1 < list1.Length)
                temp[current3++] = list1[current1++];

            while (current2 < list2.Length)
                temp[current3++] = list2[current2++];
        }
    }
}
