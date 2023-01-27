/*
 * aoife hunt
 * 26 01 23
 * 
 * Write a method, PrintExcludingFor, which uses a  for loop to print all integers between 40 and 60 excluding 46 and 48
 */

namespace Q1_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintExcludingFor();
        }

        static void PrintExcludingFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i==46 || i==48)
                    Console.WriteLine();
                else
                    Console.WriteLine(i);
            }
        }
    }
}