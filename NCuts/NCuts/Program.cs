using System;

namespace NCuts
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Tests
            int i = 0;
            for (; i <= 100; i++)
            {
                Console.WriteLine("StickLength: " + i + ", minimum cuts: " + minimumNumberOfCuts(i));
            }

            Console.ReadKey();
        }

        public static int minimumNumberOfCuts(int stickLength)
        {
            int cuts = 0;

            while (stickLength > 1)
            {
                

                if (stickLength % 2 == 0)
                {
                    // Even
                    stickLength = stickLength / 2;
                }
                else
                {
                    // Odd
                    stickLength = (int)Math.Ceiling((double)stickLength / 2);
                }

                cuts++;
            }

            return cuts;
        }
    }
}