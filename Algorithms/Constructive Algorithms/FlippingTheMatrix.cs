using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.ConstructiveAlgorithms
{
    public class FlippingTheMatrix
    {

        static int flippingMatrix(int[][] matrix, int n)
        {
            int numbersSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int maxCellValue = matrix[i][j];

                    if (maxCellValue < matrix[i][2 * n - 1 - j]) maxCellValue = matrix[i][2 * n - 1 - j];
                    if (maxCellValue < matrix[2 * n - 1 - i][j]) maxCellValue = matrix[2 * n - 1 - i][j];
                    if (maxCellValue < matrix[2 * n - 1 - i][2 * n - 1 - j]) maxCellValue = matrix[2 * n - 1 - i][2 * n - 1 - j];

                    numbersSum += maxCellValue;
                }
            }

            return numbersSum;
        }

        public void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] matrix = new int[2 * n][];
                for (int matrix_i = 0; matrix_i < 2 * n; matrix_i++)
                {
                    string[] matrix_temp = Console.ReadLine().Split(' ');
                    matrix[matrix_i] = Array.ConvertAll(matrix_temp, Int32.Parse);
                }
                int result = flippingMatrix(matrix, n);
                Console.WriteLine(result);
            }
        }
    }
}