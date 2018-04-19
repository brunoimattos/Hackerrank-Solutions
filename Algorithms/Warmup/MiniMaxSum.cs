using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class MiniMaxSum
    {

        static void miniMaxSum(long[] arr)
        {
            long minNumber = arr[0], maxNumber = arr[0];
            foreach (long number in arr)
            {
                if (number < minNumber) minNumber = number;
                if (number > maxNumber) maxNumber = number;
            }

            System.Console.Write(arr.Sum() - maxNumber);
            System.Console.Write(" ");
            System.Console.Write(arr.Sum() - minNumber);
        }

        public void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            miniMaxSum(arr);
        }
    }
}