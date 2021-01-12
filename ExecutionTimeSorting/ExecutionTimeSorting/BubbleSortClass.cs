using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionTimeSorting
{
    class BubbleSortClass
    {
        public BubbleSortClass()
        {

        }

        public int[] bubbleSort(int [] array)
        {
            bool needNextPass = true;

            for (int k = 1; k < array.Length && needNextPass; k++)
            {
                needNextPass = false;
                for (int i = 0; i < array.Length - k; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        needNextPass = true;
                    }
                }
            }
            return array;
        }
    }
}
