using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Strings
{
    public class CamelCase {

        static int camelcase(string s) {
            return s.Where(c => Char.IsUpper(c)).Count() + 1;
        }

        public void Main(String[] args) {
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine(result);
        }
    }   
}
