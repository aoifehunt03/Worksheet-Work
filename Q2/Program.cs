/*
 * aoife hunt
 * 26 01 23
 * 
 * Write a method, CountOddNumbers, which reads in 5 integer values from the console, and returns the number of them which are odd
 */

namespace Q2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CountOddNumbers();
        }

        static void CountOddNumbers()
        {
            int digitCount = 1;
            int finalOdd;
            int countOdd = 0;

            while (digitCount <= 5)
            {
                Console.Write("insert a number : ");
                string inputString = Console.ReadLine();

                digitCount++;

                for (int i = 0; i < inputString.Length; i++)
                {
                    if ((int.Parse(inputString[i].ToString()) % 2) != 0)
                    {
                        countOdd++;
                        finalOdd = countOdd;
                    }
                }
            }
            Console.WriteLine("There are " + finalOdd + " odd numbers");
        }
    }
}
