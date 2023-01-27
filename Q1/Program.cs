/*
 * aoife hunt
 * 24 01 23
 * 
 * Write a method called PrintIntegersFor which uses a for loop to print all the integers between 40 and 60 in ascending order to the console
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersFor();
        }

        static int PrintIntegersFor()
        { 
            int i;
            for (i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
                i++;
            }
            return i;
        }
    }
}