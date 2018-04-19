using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class Kangaroo
    {

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int advancedKangaroo = x1 > x2 ? 1 : 2;
            int fastestKangaroo = v1 > v2 ? 1 : 2;

            if (x1 == x2) return "YES";

            if (v1 == v2) return "NO";

            if ((advancedKangaroo == 1 && fastestKangaroo == 2) ||
                (advancedKangaroo == 2 && fastestKangaroo == 1))
            {
                if (Math.Abs(x1 - x2) % Math.Abs(v1 - v2) == 0)
                {
                    return "YES";
                }
            }

            return "NO";
        }

        public void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}