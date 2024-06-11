using System.Collections.Concurrent;

namespace algorithm_test
{
    internal class Program

    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Algorithm.QuadThread(25, '+');
                Console.WriteLine();
            }
        }
    }
}
