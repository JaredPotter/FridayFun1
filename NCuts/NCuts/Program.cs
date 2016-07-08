using System;

namespace NCuts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Tests
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("StickLength: " + i + ", minimum cuts: " + minimumNumberOfCuts(i));
            }

            Console.ReadKey();
        }

        public static int minimumNumberOfCuts(int stickLength)
        {
            int cuts = 0;
            bool lastCutOdd = false;

            if (stickLength <= 1)
            {
                return cuts;
            }

            while (stickLength != 1)
            {
                if (stickLength % 2 == 0)
                {
                    // Even
                    stickLength = stickLength / 2;
                    cuts++;
                    lastCutOdd = false;
                }
                else
                {
                    // Odd
                    stickLength = stickLength / 2;
                    cuts += 2; // accounts for odd numbers
                    lastCutOdd = true;
                }
            }

            if (lastCutOdd)
            {
                cuts--;
            }

            return cuts;
        }
    }
}