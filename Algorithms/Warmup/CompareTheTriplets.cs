using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class CompareTheTriplets
    {

        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int aPoints = 0;
            int bPoints = 0;

            if (a0 > b0)
            {
                aPoints++;
            }
            else if (a0 < b0)
            {
                bPoints++;
            }

            if (a1 > b1)
            {
                aPoints++;
            }
            else if (a1 < b1)
            {
                bPoints++;
            }

            if (a2 > b2)
            {
                aPoints++;
            }
            else if (a2 < b2)
            {
                bPoints++;
            }

            return new int[] { aPoints, bPoints };
        }

        public void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}