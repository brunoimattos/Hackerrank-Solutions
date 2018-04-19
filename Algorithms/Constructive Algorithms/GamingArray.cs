using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.ConstructiveAlgorithms
{
    public class GamingArray
    {

        static string getWinner(int[] initialGame)
        {
            int moves = 0;
            int maxNumber = -1;

            for (int i = 0; i < initialGame.Count(); i++)
            {
                if (initialGame[i] > maxNumber)
                {
                    maxNumber = initialGame[i];
                    moves++;
                }
            }

            if ((moves % 2) == 0) return "ANDY"; else return "BOB";
        }

        public void Main(String[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < g; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] gameString = Console.ReadLine().Split(' ');
                int[] initialGame = Array.ConvertAll(gameString, Int32.Parse);
                System.Console.WriteLine(getWinner(initialGame));
            }
        }
    }
}