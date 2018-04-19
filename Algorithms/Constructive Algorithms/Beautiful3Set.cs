using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.ConstructiveAlgorithms
{
    public class Beautiful3Set
    {
        public void Main(String[] args)
        {

            int number = Convert.ToInt32(System.Console.ReadLine());
            List<int> usedY = new List<int>();
            List<int> usedZ = new List<int>();

            List<List<int>> beautifulSequences = new List<List<int>>();
            for (int i = number - 1; i >= 0; i--)
            {
                beautifulSequences.Add(new List<int>() { i, 0, 0 });
            }

            for (int i = beautifulSequences.Count - 1; i >= 0; i--)
            {
                int possibleNumber = number - beautifulSequences[i][0] - 1;
                int possibleNumber2 = 1;

                for (int j = 0; j < number; j++)
                {
                    possibleNumber -= j;
                    possibleNumber2 += j; 

                    if (possibleNumber < 0) {
                        beautifulSequences.RemoveAt(i);
                        break;
                    }

                    if (usedY.IndexOf(possibleNumber) == -1 &&
                        usedZ.IndexOf(possibleNumber2) == -1)
                    {
                        usedY.Add(possibleNumber);
                        usedZ.Add(possibleNumber2);

                        beautifulSequences[i][1] = possibleNumber;
                        beautifulSequences[i][2] = possibleNumber2;

                        break;
                    }
                    else if (usedY.IndexOf(possibleNumber2) == -1 &&
                              usedZ.IndexOf(possibleNumber) == -1)
                    {
                        usedY.Add(possibleNumber2);
                        usedZ.Add(possibleNumber);

                        beautifulSequences[i][1] = possibleNumber2;
                        beautifulSequences[i][2] = possibleNumber;

                        break;
                    }
                }
            }

            System.Console.WriteLine(beautifulSequences.Count());
            printLists(beautifulSequences);
        }

        static void printLists(List<List<int>> lists)
        {
            foreach (List<int> listItem in lists)
            {
                System.Console.WriteLine(string.Join(" ", listItem));
            }
        }
    }
}
