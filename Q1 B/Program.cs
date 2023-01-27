/*
 * aoife hunt
 * 24 01 23
 * 
 * Write a second method called PrintIntegersWhile which does the same thing using a while loop
 */

namespace Q1_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersWhile();
        }

        static void PrintIntegersWhile()
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}