using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class NonDivisibleSubset
    {

        static int nonDivisibleSubset(int k, int[] arr)
        {
            int[] modList = new int[k];
            int maxNumberCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                modList[arr[i] % k]++;
            }

            if (modList[0] > 0) { maxNumberCount++; }

            for (int i = 1; i <= k / 2; i++)
            {
                if (i == k - i && modList[i] > 0) { maxNumberCount++; }
                else
                {
                    maxNumberCount += Math.Max(modList[i], modList[k - i]);
                }
            }

            return maxNumberCount;
        }

        public void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = nonDivisibleSubset(k, arr);
            Console.WriteLine(result);
        }
    }
}