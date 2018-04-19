using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class PlusMinus
    {

        static void plusMinus(int[] arr, int N)
        {
            float positiveNumbers = 0;
            float negativeNumbers = 0;
            float zeroNumbers = 0;

            foreach (int number in arr)
            {
                if (number > 0)
                {
                    positiveNumbers++;
                }
                else if (number < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    zeroNumbers++;
                }
            }

            System.Console.WriteLine(positiveNumbers / N);
            System.Console.WriteLine(negativeNumbers / N);
            System.Console.WriteLine(zeroNumbers / N);
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr, n);
        }
    }
}