using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutionTimeSorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            checkInsertionSort();
            //checkBubbleSort();
            checkRadixSort();
            checkBucketSort();
            checkMergeSort();
            checkQuickSort();
            checkCounterSort();
        }

        public void insertionSort(int [] array)
        {
            var start = Stopwatch.StartNew();

            InsertionSortClass sort = new InsertionSortClass();
            int[] sortedArray = sort.insertionSort(array);

            stopAndCheck(start, sortedArray, lstBxInsertion);
        }

        public void bubbleSort(int[] array)
        {
            var start = Stopwatch.StartNew();

            BubbleSortClass sort = new BubbleSortClass();
            int[] sortedArray = sort.bubbleSort(array);

            stopAndCheck(start, sortedArray, lstBxBubble);
        }

        public void mergeSort(int [] array)
        {
            var start = Stopwatch.StartNew();

            MergeSortClass sort = new MergeSortClass();
            int[] sortedArray = sort.mergeSort(array);

            stopAndCheck(start, sortedArray, lstBxMerge);
        }

        public void radixSort(int[] array)
        {
            var start = Stopwatch.StartNew();

            RadixSortClass sort = new RadixSortClass();
            int[] sortedArray = sort.radixSort(array);

            stopAndCheck(start, sortedArray, lstBxRadix);
        }

        public void bucketSort(int[] array)
        {
            var start = Stopwatch.StartNew();

            BucketSortClass sort = new BucketSortClass();
            int[] sortedArray = sort.bucketSort(array);

            stopAndCheck(start, array, lstBxBucket);
        }

        public void quickSort(int[] array)
        {
            var start = Stopwatch.StartNew();

            QuickSortClass sort = new QuickSortClass();
            int[] sortedArray = sort.quickSort1(array);

            stopAndCheck(start, sortedArray, lstBxQuick);
        }      

        public void counterSort(int[] array)
        {
            var start = Stopwatch.StartNew();

            CounterSortClass sort = new CounterSortClass();
            int[] sortedArray = sort.couterSort(array);

            stopAndCheck(start, sortedArray, lstBxCounter);
        }

        public static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void stopAndCheck(Stopwatch start, int[] array, ListBox list)
        {
            start.Stop();
            string end = (start.Elapsed.TotalMilliseconds).ToString("0.00");
            list.Items.Add(end + "\n");
            list.Items.Add("\n");
            list.Items.Add("\n");

            bool check = IsSorted(array);

            if (check == true)
            {
                lblError.Text += "S";
            }
            else
                lblError.Text += "E";
        }

        public void checkInsertionSort()
        {
            Random rand = new Random();
            for (int i = 0, k = 5000; i < 6; i++, k = k + 5000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand.Next(1, 10);
                }
                insertionSort(array);
            }
        }

        //public void checkBubbleSort()
        //{
        //    Random rand2 = new Random();
        //    for (int i = 0, k = 5000; i < 6; i++, k = k + 5000)
        //    {
        //        int[] array = new int[k];
        //        for (int j = 0; j < k; j++)
        //        {
        //            array[j] = rand2.Next(1, 1000);
        //        }
        //        bubbleSort(array);
        //    }
        //}

        public void checkRadixSort()
        {
            Random rand3 = new Random();
            for (int i = 0, k = 50000; i < 6; i++, k = k + 50000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand3.Next(1, 1000);
                }
                radixSort(array);
            }
        }

        public void checkBucketSort()
        {
            Random rand4 = new Random();
            for (int i = 0, k = 50000; i < 6; i++, k = k + 50000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand4.Next(1, 1000);
                }
                bucketSort(array);
            }
        }

        public void checkMergeSort()
        {
            Random rand5 = new Random();
            for (int i = 0, k = 50000; i < 6; i++, k = k + 50000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand5.Next(1, 1000);
                }
                mergeSort(array);
            }
        }

        public void checkQuickSort()
        {
            Random rand6 = new Random();
            for (int i = 0, k = 50000; i < 6; i++, k = k + 50000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand6.Next(1, 1000);
                }
                quickSort(array);
            }
        }

        public void checkCounterSort()
        {
            Random rand7 = new Random();
            for (int i = 0, k = 50000; i < 6; i++, k = k + 50000)
            {
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[j] = rand7.Next(1, 1000);
                }
                counterSort(array);
            }
        }
    }
}
