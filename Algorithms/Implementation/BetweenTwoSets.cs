using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class BetweenTwoSets
    {

        static int getTotalX(int[] a, int[] b)
        {
            IEnumerable<int> orderedA = a.OrderByDescending(item => item);
            IEnumerable<int> orderedB = b.OrderBy(item => item);

            int numberRange1 = orderedA.Take(1).ToList().FirstOrDefault();
            int numberRange2 = orderedB.Take(1).ToList().FirstOrDefault();

            int countOcurrences = 0;

            for (int i = numberRange1; i <= numberRange2; i++)
            {
                bool isBetween = true;

                foreach (int n in a)
                {
                    if (i % n != 0)
                    {
                        isBetween = false;
                        break;
                    }
                }

                foreach (int n in b)
                {
                    if (n % i != 0)
                    {
                        isBetween = false;
                        break;
                    }
                }

                if (isBetween)
                {
                    countOcurrences++;
                }
            }

            return countOcurrences;
        }

        public void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }
    }
}