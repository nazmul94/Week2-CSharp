using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = new int[5];

            //Console.WriteLine("Please enter 5 numbers ");

            //int sum = 0;
            //double average;

            //foreach (int i in myArray)
            //{
            //    int num = Int32.Parse(Console.ReadLine());
            //    myArray[i] = num;
            //    sum += num;
            //}

            //average = sum / myArray.Length;
            //Console.WriteLine("The average is: " + average);

            int[,] multiArray = new int[5, 5] { 
                                                { 1, 2, 3, 4, 5 },
                                                { 1, 2, 3, 4, 5 },
                                                { 1, 2, 3, 4, 5 },
                                                { 1, 2, 3, 4, 5 },
                                                { 1, 2, 3, 4, 5 }
                                            };

            int grandSum = 0;
            int rowTotal = 0;
            int columnTotal = 0;

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {

                for ( int j = 0; j < multiArray.GetLength(1); j++)
                {
                    grandSum += multiArray[i, j];

                    rowTotal += multiArray[i, j];
                }

                Console.WriteLine("The total for row " + (i+1) + " is " + rowTotal);
                rowTotal = 0;

                for(int k =0; k < multiArray.GetLength(0); k++)
                {
                    columnTotal = multiArray[i, k];
                }

                Console.WriteLine("The total for column " + (i+1) + " is " + columnTotal);
                columnTotal = 0;
            }


            Console.WriteLine("The grand total of all the entries within the array is " + grandSum);
        }
    }
}
