using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class AppleAndOrange
    {

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {

            int appleCount = 0;
            int orangeCount = 0;

            foreach (int apple in apples)
            {
                if (((apple + a) >= s) && ((apple + a) <= t))
                {
                    appleCount++;
                }
            }

            System.Console.WriteLine(appleCount);

            foreach (int orange in oranges)
            {
                if (((orange + b) >= s) && ((orange + b) <= t))
                {
                    orangeCount++;
                }
            }

            System.Console.WriteLine(orangeCount);
        }

        public void Main(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
            countApplesAndOranges(s, t, a, b, apple, orange);
        }
    }
}