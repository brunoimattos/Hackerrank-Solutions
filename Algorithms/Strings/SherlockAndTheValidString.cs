using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Strings
{

    public class SherlockAndTheValidString
    {
        static string isValid(string s)
        {
            IEnumerable<char> differentChars = s.Distinct();
            int[] charCounts = new int[differentChars.Count()];

            if (differentChars.Count() == 1) return "YES";

            for (int i = 0; i < differentChars.Count(); i++)
            {
                char charI = differentChars.ElementAt(i);
                charCounts[i] = s.Count(c => c == charI);
            }

            int maxCount = charCounts.Max();
            int minCount = charCounts.Min();

            if (maxCount == minCount ||
                ((maxCount - minCount == 1) && charCounts.Count(i => i == maxCount) == 1) ||
                (minCount == 1 && charCounts.Count(j => j == minCount) == 1))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        public void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = isValid(s);
            Console.WriteLine(result);
        }
    }
}