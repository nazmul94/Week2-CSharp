using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    num[i] = i * 10;
                    Console.WriteLine(num[i]);
                }
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Caught exception: {0}", e.Message);
            }

            int firstNum = 5;
            int secNum = 0;
            double result;

            try
            {
                result = firstNum / secNum;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }

        }
    }
}