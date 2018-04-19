using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class Staircase
    {

        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {

                String spaces = new String(' ', n - i);
                System.Console.Write(spaces);

                String hashtags = new String('#', i);
                System.Console.Write(hashtags);

                System.Console.WriteLine();
            }
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
    }
}
