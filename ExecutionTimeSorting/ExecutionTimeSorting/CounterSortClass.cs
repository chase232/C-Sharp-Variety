using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionTimeSorting
{
    class CounterSortClass
    {
        public CounterSortClass()
        {

        }

        public int[] couterSort(int[] array)
        {
            // setting sortedArray to have the same number of values as the passed array
            int[] sortedArray = new int[array.Length];
            int aLength = array.Length;

            // finding the smallest and largest number
            int minNum = array[0];
            int maxNum = array[0];
            for (int i = 1; i < aLength; i++)
            {
                if (array[i] < minNum)
                {
                    minNum = array[i];
                }
                else if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }

            // creating an array of the frequencies
            // array count is used to hold the number of frequincies
            int[] count = new int[maxNum - minNum + 1];

            // for loop used to find the frequincies
            for (int i = 0; i < aLength; i++)
            {
                count[array[i] - minNum] = count[array[i] - minNum] + 1;
            }
            count[0] = count[0] - 1;

            // looping through count array 
            int cLength = count.Length;
            for (int i = 1; i < cLength; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            // Sorting the array
            for (int i = aLength - 1; i >= 0; i--)
            {
                sortedArray[count[array[i] - minNum]--] = array[i];
            }

            return sortedArray;
        }
    }
}
