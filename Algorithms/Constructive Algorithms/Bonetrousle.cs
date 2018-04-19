using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hackerrank.Algorithms.ConstructiveAlgorithms
{
    public class Bonetrousle
    {
        static void printBoxes(long exactSticksToBuy, long storeBoxes, long exactBoxesToBuy)
        {
            long[] boxes = new long[exactBoxesToBuy];
            
            if (storeBoxes < exactBoxesToBuy)
            {
                System.Console.WriteLine("-1");
                return;
            }

            for (int i = 0; i < exactBoxesToBuy; i++)
            {
                boxes[i] = i + 1;
            }

            long boxesCount = boxes.Sum();

            if (boxesCount > exactSticksToBuy)
            {
                System.Console.WriteLine("-1");
                return;
            }

            long maxBoxAvailable = storeBoxes;

            for (long i = exactBoxesToBuy; i > 0; i--)
            {
                if (boxesCount == exactSticksToBuy)
                {
                    break;
                }
                else
                {
                    long sticksLeftToBuy = exactSticksToBuy - boxesCount;
                    long buySticks = Math.Min(sticksLeftToBuy + boxes[i - 1], maxBoxAvailable);
                    
                    long temp = boxes[i - 1];
                    boxes[i - 1] = buySticks;
                    boxesCount += buySticks - temp;
                    maxBoxAvailable = buySticks - 1;
                }
            }

            if (boxesCount == exactSticksToBuy)
            {
                if (boxes.Length != boxes.Distinct().Count())
                {
                    System.Console.WriteLine("-1");
                    return;
                }

                printSelectedBoxes(boxes);
                return;
            }
            else
            {
                System.Console.WriteLine("-1");
                return;
            }
        }
        static void printSelectedBoxes(long[] boxes)
        {
            System.Console.Write(string.Join(" ", boxes));
            System.Console.WriteLine();
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] config = System.Console.ReadLine().Split(' ');
                long[] numbers = Array.ConvertAll(config, Int64.Parse);
                printBoxes(numbers[0], numbers[1], numbers[2]);
            }
        }
    }
}
