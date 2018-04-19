using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class BirthdayCakeCandles
    {

        static int birthdayCakeCandles(int n, int[] ar)
        {
            int maxHeight = 0;
            int numberOfCandles = 0;

            foreach (int height in ar)
            {
                if (height == maxHeight)
                {
                    numberOfCandles++;
                }
                else if (height > maxHeight)
                {
                    numberOfCandles = 1;
                    maxHeight = height;
                }
            }

            return numberOfCandles;
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}