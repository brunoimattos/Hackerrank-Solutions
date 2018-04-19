using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.Warmup
{
    public class DiagonalDifference
    {

        static int diagonalDifference(int[][] a, int N)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < N; i++)
            {
                firstDiagonal += a[i][i];
                secondDiagonal += a[(N - 1) - i][i];
            }

            return Math.Abs(firstDiagonal - secondDiagonal);
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a, n);
            Console.WriteLine(result);
        }
    }
}