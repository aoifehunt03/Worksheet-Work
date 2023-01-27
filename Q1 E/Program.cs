/*
 * aoife hunt
 * 26 01 23
 * 
 * Write a method, PrintDescendingFor, which uses a for loop to print all integers between 60 and 40 in descending order
 */

namespace Q1_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDescendingFor();
        }

        static void PrintDescendingFor()
        {
            for (int i = 60; i>=40; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}