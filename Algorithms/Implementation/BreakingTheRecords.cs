using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class BreakingTheRecords
    {

        static int[] breakingRecords(int[] score)
        {
            int[] result = new int[2] { 0, 0 };

            if (score.Length == 0) return result;

            int lowestRecord = score[0];
            int highestRecord = score[0];

            foreach (int v in score)
            {
                if (v < lowestRecord)
                {
                    lowestRecord = v;
                    result[1] = result[1] + 1;
                }

                if (v > highestRecord)
                {
                    highestRecord = v;
                    result[0] = result[0] + 1;
                }
            }

            return result;
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] score_temp = Console.ReadLine().Split(' ');
            int[] score = Array.ConvertAll(score_temp, Int32.Parse);
            int[] result = breakingRecords(score);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}