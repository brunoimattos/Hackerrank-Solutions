using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Implementation
{
    public class FormingAMagicSquare
    {

        static int formingMagicSquare(int[][] s)
        {
            List<int[][]> possibleMagicForms = new List<int[][]> {

            new int[][] { new int[] {8, 1, 6}, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
            new int[][] { new int[] {6, 1, 8}, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
            new int[][] { new int[] {4, 9, 2}, new int[] {3, 5, 7}, new int[] {8, 1, 6} },
            new int[][] { new int[] {2, 9, 4}, new int[] {7, 5, 3}, new int[] {6, 1, 8} },
            new int[][] { new int[] {8, 3, 4}, new int[] {1, 5, 9}, new int[] {6, 7, 2} },
            new int[][] { new int[] {4, 3, 8}, new int[] {9, 5, 1}, new int[] {2, 7, 6} },
            new int[][] { new int[] {6, 7, 2}, new int[] {1, 5, 9}, new int[] {8, 3, 4} },
            new int[][] { new int[] {2, 7, 6}, new int[] {9, 5, 1}, new int[] {4, 3, 8} },

        };

            int[] costsToTransform = new int[8];

            for (int i = 0; i < possibleMagicForms.Count; i++)
            {
                for (int j = 0; j < possibleMagicForms[i].Length; j++)
                {
                    for (int k = 0; k < possibleMagicForms[i][j].Length; k++)
                    {
                        costsToTransform[i] += Math.Abs(possibleMagicForms[i][j][k] - s[j][k]);
                    }
                }
            }

            return costsToTransform.Min();
        }

        static bool checkMagicSquare(int[][] s, int sum)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Sum() != sum) return false; //column check

                int rowCount = 0;

                for (int j = 0; j < s[i].Length; j++)
                {
                    rowCount += s[i][j];
                }

                if (rowCount != sum) return false; //row check
            }

            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                diagonal1 += s[i][i];
                diagonal2 += s[i][s.Length - 1 - i];
            }

            if (diagonal1 != sum || diagonal2 != sum) return false;

            return true;
        }

        public void Main(String[] args)
        {
            int[][] s = new int[3][];
            for (int s_i = 0; s_i < 3; s_i++)
            {
                string[] s_temp = Console.ReadLine().Split(' ');
                s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
            }
            int result = formingMagicSquare(s);
            Console.WriteLine(result);
        }
    }
}