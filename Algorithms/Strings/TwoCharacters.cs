using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Strings
{
    public class TwoCharaters
    {
        static int twoCharaters(string s)
        {
            IEnumerable<char> distinctChars = s.Distinct();

            int maxCount = 0;

            for (int i = 0; i < distinctChars.Count(); i++)
            {
                for (int j = i + 1; j < distinctChars.Count(); j++)
                {
                    string removedCharString = String.Concat(s.Where(c2 => c2 == distinctChars.ElementAt(i) || c2 == distinctChars.ElementAt(j)));
                    if (isSequenceAlternating(removedCharString))
                    {
                        maxCount = Math.Max(maxCount, removedCharString.Length);
                    }
                }
            }

            return maxCount;
        }

        static bool isSequenceAlternating(string s)
        {
            if (s.Length == 0) return true;
            if (s.Length == 1) return false;

            for (int i = 2; i < s.Length; i++)
            {
                if (s[i % 2] != s[i]) return false;
            }

            return true;
        }

        public void Main(String[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = twoCharaters(s);
            Console.WriteLine(result);
        }
    }
}