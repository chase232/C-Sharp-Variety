using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionTimeSorting
{
    class InsertionSortClass
    {
        private int[] array;
        private int numberOfIntegers;

        public InsertionSortClass()
        {

        }

        public int[] insertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int k;
                int currentElement = array[i];
                for (k = i - 1; k >= 0 && array[k] > currentElement; k--)
                {
                    array[k + 1] = array[k];
                }
                array[k + 1] = currentElement;
            }

            return array;
        }
    }
}
