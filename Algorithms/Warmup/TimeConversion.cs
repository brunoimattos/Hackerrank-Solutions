using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class TimeConversion
    {

        static string timeConversion(string s)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime date = DateTime.ParseExact(s, "hh:mm:sstt", provider);
            return date.ToString("HH:mm:ss");
        }

        public void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}