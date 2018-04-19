using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Hackerrank.Algorithms.Implementation
{

    public class ExtraLongFactorials
    {

        static void extraLongFactorials(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            System.Console.WriteLine(result.ToString());
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            extraLongFactorials(n);
        }
    }
}