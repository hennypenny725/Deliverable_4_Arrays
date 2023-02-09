/* Author: Thomas Overholt
 * Date: 2/8/2023
 * Comment: Application demostrates the use of arrays using the Fibonacci Sequence
*/


using System;
using System.Net.Http.Headers;

namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] even = new int[25];
            int[] odd = new int[25];
            int[] fibonacci = new int[25];

            //Begin the Fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < 25; i++)
            {
                even[i] = 2 * i;
                odd[i] = 2 * i + 1;

                if(i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i-2];
                }
            }

            //placeholder for position of array to be displayed
            int p = 0;

            //Display all fibonacci numbers in console
            foreach (int number in fibonacci) 
            {
                {
                    Console.WriteLine("Fibonacci number ({0}) = {1}",p ,number);
                }
                p++;
            }

        }
    }
}