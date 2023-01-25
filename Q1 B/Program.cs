namespace Q1_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersWhile();
        }

        static int PrintIntegersWhile()
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine(i);
                i++;
            }
            return i;
        }
    }
}