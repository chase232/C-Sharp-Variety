using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LargestArray
{
    /// <summary>
    /// Class:      LargestArray
    /// Developer:  Chase Dickerson
    /// Date:       10/3/2017
    /// Purpose:    To randomly generate a 2D array and find the largest value
    /// </summary>
    class LargestArray
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string inputValue;
            int r;
            int c;

            // Asking for number of rows
            WriteLine("Enter the number of rows: ");
            inputValue = ReadLine();
            r = int.Parse(inputValue);

            // Asking for number of columns
            WriteLine("Enter the number of columns: ");
            inputValue = ReadLine();
            c = int.Parse(inputValue);

            WriteLine(" ");

            // Declare random object
            Random rand = new Random();

            // Creating new array
            int[,] array = new int[r, c];

            WriteLine("Array Values: ");

            // Populating 2D array with random number
            // first for loop used for rows
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // second for loop used for columns
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Write(array[i,j] + "\t");
                }
                WriteLine(" ");
            }
            
            // variables used to find largest number and its index
            int largest = array[0, 0];
            int index1 = 0;
            int index2 = 0;

            // Nested for loop to find largest number and index
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int current = array[i, j];

                    // Checking if the current value is larger
                    if (current > largest)
                    {
                        largest = current;
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            
            WriteLine("Largest Value is: " + largest);
            WriteLine("Index for Largest Number: " + index1 + ", " + index2);

            ReadKey();
        }       
    }
}
