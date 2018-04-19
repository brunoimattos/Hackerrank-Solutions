using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class climbingTheLeaderboard
    {

        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] result = new int[alice.Length];
            int i = 0;

            int lastPosition = 1;
            int lastScore = scores[i];

            for (int j = alice.Length - 1; j > -1; j--)
            {
                for (int k = i; k < scores.Length; k++)
                {
                    if (lastScore > scores[k])
                    {
                        lastPosition++;
                        lastScore = scores[k];
                    }

                    if (alice[j] >= scores[k])
                    {
                        result[j] = lastPosition;
                        i = k;
                        break;
                    }
                }

                if (result[j] == 0)
                {
                    result[j] = lastPosition + 1;
                    i = scores.Length;
                }
            }

            return result;
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            int[] result = climbingLeaderboard(scores, alice);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}