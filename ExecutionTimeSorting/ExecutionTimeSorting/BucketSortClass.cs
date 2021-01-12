using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionTimeSorting
{
    class BucketSortClass
    {
        public BucketSortClass()
        {

        }

        public int[] bucketSort(int[] array)
        {
            // Declaring variables
            int totalValuesPlaces;

            // Creating the 2D buckets array 
            int[,] bucket = new int[10, array.Length];

            // Used to find the number of value places in the largest num
            totalValuesPlaces = DetermineTotalNumOfValue(array);

            // for loop used to loop the number of times as the number 
            // returned to the variable totalValuesPlaces (which holds the 
            // the number of value places for the largest num) 
            for (int j = 1; j <= totalValuesPlaces; j++)
            {
                // Calls to methods
                DistributionPass(bucket, array.Length, j, array);
                GatheringPass(bucket, array, array.Length);
                //DisplayGatheringPass(bucket, array);

                if (j != totalValuesPlaces)
                {
                    ResetBucket(bucket);
                }
            }
            return array;
        }

        // This method determines the number of place values for the largest num
        public int DetermineTotalNumOfValue(int[] array)
        {
            int largest = array[0];
            //int values = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }

            // Finding number of places using the variable largest
            int values = (int)(Math.Floor(Math.Log10(largest)) + 1);

            return values;
        }

        // This method distributes the array values in the bucket array
        public void DistributionPass(int[,] bucket, int num, int j, int[] array)
        {
            // Declaring variables
            int divisor = 10;

            int bucketNum;
            int elementNum;

            for (int i = 1; i < j; i++)
            {
                divisor = divisor * 10;
            }

            // loop used to place each value in array in the correct bucket
            for (int i = 0; i < num; i++)
            {
                // finding the specified place value
                bucketNum = (array[i] % divisor - array[i] % (divisor / 10)) / (divisor / 10);

                elementNum = ++bucket[bucketNum, 0];

                // Adding bucket num to the rows
                bucket[bucketNum, elementNum] = array[i];
            }

        }

        // This mehtod gathers the values from the bucket array
        public void GatheringPass(int[,] bucket, int[] array, int num)
        {
            int temp = 0;

            // Looping through the bucket array
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= bucket[i, 0]; j++)
                {
                    // Add elements to array
                    array[temp++] = bucket[i, j];
                }
            }
        }

        // This method resets the bucket
        public void ResetBucket(int[,] bucket)
        {
            for (int i = 0; i < 10; i++)
                bucket[i, 0] = 0;
        }
    }
}
