namespace Q1_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintExcludingFor();
        }

        static int PrintExcludingFor()
        {
            int i;
            for (i = 40; i <= 60 && i != 48 && i != 46; i++)
            {
                Console.WriteLine(i);
                i++;
            }
            return i;
        }
    }
}