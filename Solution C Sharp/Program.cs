using System;

namespace Solution_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result  = Solution.Summary();

            Console.WriteLine($"Total Sum: {result}");
        }
    }
}