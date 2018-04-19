using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.ConstructiveAlgorithms
{
    public class NewYearChaos
    {
        static void minimumBribes(int[] q, int n)
        {
            int bribe = 0;
            bool chaotic = false;

            for (int i = 0; i < n; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    chaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        bribe++;
            }
            if (chaotic)
                System.Console.WriteLine("Too chaotic");
            else
                System.Console.WriteLine(bribe);
        }

        static void swap(int a, int b, int[] array)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] q_temp = Console.ReadLine().Split(' ');
                int[] q = Array.ConvertAll(q_temp, Int32.Parse);
                minimumBribes(q, n);
            }
        }
    }
}