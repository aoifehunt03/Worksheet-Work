/*
 * aoife hunt
 * 24 01 23
 * 
 * Write a third method, PrintIntegersDo, which does the same thing using a do..while loop
 */

namespace Q1_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersDo();
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
    }
}