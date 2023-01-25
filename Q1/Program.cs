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