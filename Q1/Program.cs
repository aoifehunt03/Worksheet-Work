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
            Console.WriteLine();
            PrintIntegersWhile();
            Console.WriteLine();
            PrintIntegersDo();
            Console.WriteLine();
            PrintExcludingFor();
            Console.WriteLine();
            PrintDescendingFor();
        }

        static void PrintIntegersFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
                i++;
            }
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

        static void PrintIntegersDo()
        {
            int i = 40;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 60);
        }

        static void PrintExcludingFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i == 46 || i == 48)
                    Console.WriteLine();
                else
                    Console.WriteLine(i);
            }
        }

        static void PrintDescendingFor()
        {
            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}