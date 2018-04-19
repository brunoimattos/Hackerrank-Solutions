using System;
using System.Collections.Generic;
using System.IO;

namespace Hackerrank.Algorithms.Warmup
{
    public class SolveMeFirst
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        public void Main(String[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}